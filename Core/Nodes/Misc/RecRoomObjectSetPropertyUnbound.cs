/*
 * Filename: RecRoomObjectSetPropertyUnbound.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the specified property to the provided value on the target object. Will error if the object does not have this property, so use Has Property to verify first if there is any uncertainty
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("bb78b977-b1db-4f49-be90-7abed31f1477")]
public class RecRoomObjectSetPropertyUnbound : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Set Property (Unbound)";
    public string GetVariableQualifiedName() => "recRoomObjectSetPropertyUnbound";
}