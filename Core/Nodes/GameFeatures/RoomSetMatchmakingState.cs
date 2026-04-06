/*
 * Filename: RoomSetMatchmakingState.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set whether this instance of the room is visible to Rec Room's matchmaking. If false, new players will not be directed this instance unless they are joining a friend. Useful for games where joining in progress is disruptive.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Matchmaking Permitted (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * On Matchmaking State Set (exec)
 * Matchmaking Permitted (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("be4decd2-56a0-46af-8e96-091261946fd9")]
public class RoomSetMatchmakingState : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Set Matchmaking State";
    public string GetVariableQualifiedName() => "roomSetMatchmakingState";
}