/*
 * Filename: RecRoomObjectGetIsAttachedtoaPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the Rec Room Object is currently attached to a player.
 * Types: 
 * 
 * INPUTS: 
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * Is Attached (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("06ee8c41-e34f-4427-a8f6-ca7631b5e057")]
public class RecRoomObjectGetIsAttachedtoaPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Get Is Attached to a Player";
    public string GetVariableQualifiedName() => "recRoomObjectGetIsAttachedtoaPlayer";
}