/*
 * Filename: GetPlayerAccountFromPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the Player Account associated with a given player
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * Player Account (Player Account)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("287fef13-0545-4f5f-bf4a-d031a346ecff")]
public class GetPlayerAccountFromPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player Account From Player";
    public string GetVariableQualifiedName() => "getPlayerAccountFromPlayer";
}