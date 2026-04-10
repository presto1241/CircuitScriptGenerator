/*
 * Filename: Port.cs
 * Created Date: Tuesday, March 31st 2026, 11:35:50 pm
 * Author: Preston
 * 
 * Description: This is a port on a chip.
 */
namespace CircuitScriptGenerator.Core.Data;
/// <summary>
/// An enum to define what type of port it is.
/// </summary>
public enum PortType
{
    Execution,
    Value,
    Constant
}

/// <summary>
/// An interface to store a port type and its value.
/// </summary>
internal interface IPortValue
{
    void SetValue(object value);
    object GetValue();
    Type ValueType { get; }
}

/// <summary>
/// A generic class to store a ports value.
/// </summary>
/// <typeparam name="T"></typeparam>
internal class PortValue<T> : IPortValue
{
    public T Value { get; private set; }

    public PortValue(T value)
    {
        Value = value;
    }

    public object GetValue() => Value!;
    public void SetValue(object value) => Value = (T)value;

    public Type ValueType => typeof(T);
}

/// <summary>
/// This is a port on a chip.
/// This port contains its direction, type, it's value, and where it points to.
/// </summary>
public class Port
{
    /// <summary>
    /// A possible reference between a connection of an output to multiple input ports
    /// </summary>
    public Connection? ConnectionReference { get; }

    /// <summary>
    /// A way to define if this port is a constant or a connection
    /// </summary>
    public PortType PortType { get; private set; }

    public List<Type> SupportedTypes { get; private set; }

    /// <summary>
    /// When the code is being generated, this variable is used to store the variable name
    /// </summary>
    public string VariableName = string.Empty;

    private IPortValue? _value;

    /// <summary>
    /// Create a new IPortValue object based on the object given
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static IPortValue CreatePortData(object value)
    {
        var type = typeof(PortValue<>).MakeGenericType(value.GetType());
        return (IPortValue)Activator.CreateInstance(type, value)!;
    }

    /// <summary>
    /// Construct a new port with the data, direction, and type
    /// </summary>
    /// <param name="data">The data of the port</param>
    /// <param name="direction">The direction of the port</param>
    /// <param name="portType">The type of port</param>
    public Port(List<Type> supportedTypes, Connection? connectionReference, PortType portType)
    {
        ConnectionReference = connectionReference;
        PortType = portType;
        SupportedTypes = supportedTypes;
    }

    /// <summary>
    /// Get the current port value casted as a specific type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T? GetValueAsType<T>()
    {
        if (_value == null) return default(T);
        return (T)_value.GetValue();
    }

    /// <summary>
    /// Get the current ports value type.
    /// </summary>
    /// <returns></returns>
    public Type? GetValueType()
    {
        if (_value == null) return null;
        return _value.ValueType;
    }

    /// <summary>
    /// Attempt to set the current value.
    /// </summary>
    /// <param name="value"></param>
    public void SetValue(object value)
    {
        if (_value == null) _value = CreatePortData(value);
        else _value.SetValue(value);
    }
}
