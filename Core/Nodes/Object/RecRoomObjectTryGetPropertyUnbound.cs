/*
 * Filename: RecRoomObjectTryGetPropertyUnbound.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not an object has this property, and if so what the value of the property is. If the object does not have the property, it will return the Default Value port as the property value instead.
 * Types: 
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Has Property (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7cf907f6-7e46-4ed5-9d85-b0f529557517")]
public class RecRoomObjectTryGetPropertyUnbound : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Try Get Property (Unbound)";
    public string GetVariableQualifiedName() => "recRoomObjectTryGetPropertyUnbound";
}