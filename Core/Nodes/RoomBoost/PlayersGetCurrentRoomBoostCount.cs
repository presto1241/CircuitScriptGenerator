/*
 * Filename: PlayersGetCurrentRoomBoostCount.cs
 * Category: Room Boost
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the number of active room boosts in the current room contributed by the specified players as a sum.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Players (List<Player>)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response (exec)
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.RoomBoost;

[Node("a808c860-69ce-4263-a302-cf952e54e7fd")]
public class PlayersGetCurrentRoomBoostCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Players Get Current Room Boost Count";
    public string GetVariableQualifiedName() => "playersGetCurrentRoomBoostCount";
}