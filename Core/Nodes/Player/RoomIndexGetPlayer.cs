/*
 * Filename: RoomIndexGetPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the player in the room with this unique index, bounded by the room capacity.
 * Types: 
 * 
 * INPUTS: 
 * Room Index (int)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("61e30876-2f28-4ba6-9d70-dfa5cc2af1cc")]
public class RoomIndexGetPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Index Get Player";
    public string GetVariableQualifiedName() => "roomIndexGetPlayer";
}