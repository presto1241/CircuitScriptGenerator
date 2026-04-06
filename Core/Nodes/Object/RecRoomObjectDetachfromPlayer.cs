/*
 * Filename: RecRoomObjectDetachfromPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Detaches a Rec Room Object from a body part on a player if it is attached.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("279b50fb-073e-4e33-b770-e1e64d601621")]
public class RecRoomObjectDetachfromPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Detach from Player";
    public string GetVariableQualifiedName() => "recRoomObjectDetachfromPlayer";
}