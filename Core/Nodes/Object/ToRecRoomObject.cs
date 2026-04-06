/*
 * Filename: ToRecRoomObject.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Casts a target specific object to a Rec Room Object.
 * Types: Rec Room Object
 * 
 * INPUTS: 
 * Target (T)
 *
 * OUTPUTS: 
 * Rec Room Object (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("315a494e-84cc-4e3c-acff-389bb932b5d0")]
public class ToRecRoomObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "To Rec Room Object";
    public string GetVariableQualifiedName() => "toRecRoomObject";
}