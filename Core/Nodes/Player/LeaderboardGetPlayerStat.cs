/*
 * Filename: LeaderboardGetPlayerStat.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get the leaderboard stat for the given player on the given stat channel.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player (Player)
 * Channel (int)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Get Stat Complete (exec)
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("12cf9781-1e1b-4e59-a783-c7214b66be8a")]
public class LeaderboardGetPlayerStat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Leaderboard Get Player Stat";
    public string GetVariableQualifiedName() => "leaderboardGetPlayerStat";
}