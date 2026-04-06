/*
 * Filename: RecRoomObjectGetAuthority.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the authority Player of the input object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Result (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9e51fcdc-87b4-4eee-a7b1-8d6f86a5fa6b")]
public class RecRoomObjectGetAuthority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Authority";
    public string GetVariableQualifiedName() => "recRoomObjectGetAuthority";
}