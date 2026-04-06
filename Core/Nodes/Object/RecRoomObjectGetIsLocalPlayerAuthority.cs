/*
 * Filename: RecRoomObjectGetIsLocalPlayerAuthority.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True on the player's machine who has authority of the input.
 * Types: 
 * 
 * INPUTS: 
 * Target (Rec Room Object)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b0497de0-3dd3-470d-a421-8f0d321bfc3e")]
public class RecRoomObjectGetIsLocalPlayerAuthority : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Is Local Player Authority";
    public string GetVariableQualifiedName() => "recRoomObjectGetIsLocalPlayerAuthority";
}