/*
 * Filename: FromRecRoomObject.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Converts the input Rec Room Object to the object's subtype.
 * Types: Rec Room Object
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Value (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7ff685a6-f59c-4c6c-b559-f343d81ea1d4")]
public class FromRecRoomObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "From Rec Room Object";
    public string GetVariableQualifiedName() => "fromRecRoomObject";
}