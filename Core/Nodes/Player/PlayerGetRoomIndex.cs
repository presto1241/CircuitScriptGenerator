/*
 * Filename: PlayerGetRoomIndex.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the unique index of this player in the room, bounded by the room capacity.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Room Index (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7683e201-29d3-44d4-abb4-d75ef9233faa")]
public class PlayerGetRoomIndex : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Room Index";
    public string GetVariableQualifiedName() => "playerGetRoomIndex";
}