/*
 * Filename: Port.cs
 * Created Date: Tuesday, March 31st 2026, 11:35:50 pm
 * Author: Preston
 * 
 * Description: This is a port on a chip.
 */
namespace CircuitScriptGenerator.Core.Data;

/// <summary>
/// An Enum to determine if the port is an input or output port.
/// </summary>
public enum PortDirection
{
    Input,
    Output
}

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
    object GetValue();
    Type ValueType { get; }
}

/// <summary>
/// A generic class to store a ports value.
/// </summary>
/// <typeparam name="T"></typeparam>
internal class PortValue<T> : IPortValue
{
    public T Value { get; }

    public PortValue(T value)
    {
        Value = value;
    }

    public object GetValue() => Value!;

    public Type ValueType => typeof(T);
}

/// <summary>
/// This is a port on a chip.
/// This port contains its direction, type, it's value, and where it points to.
/// </summary>
public class Port
{
    public PortDirection PortDirection { get; private set; }
    public PortType PortType { get; private set; }

    /// <summary>
    /// When the code is being generated, this variable is used to store the variable name.
    /// </summary>
    public string VariableName = string.Empty;

    private IPortValue _value;

    /// <summary>
    /// Create a new IPortValue object based on the object given.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static IPortValue CreatePortData(object value)
    {
        var type = typeof(PortValue<>).MakeGenericType(value.GetType());
        return (IPortValue)Activator.CreateInstance(type, value)!;
    }

    /// <summary>
    /// Construct a new port with the data, direction, and type.
    /// </summary>
    /// <param name="data">The data of the port</param>
    /// <param name="direction">The direction of the port</param>
    /// <param name="portType">The type of port</param>
    public Port(object data, PortDirection direction, PortType portType)
    {
        PortDirection = direction;
        PortType = portType;

        _value = CreatePortData(data);
    }

    /// <summary>
    /// Get the current port value casted as a specific type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public T GetValueAsType<T>()
    {
        return (T)_value.GetValue();
    }

    /// <summary>
    /// Get the current ports value type.
    /// </summary>
    /// <returns></returns>
    public Type GetValueType()
    {
        return _value.ValueType;
    }
}
