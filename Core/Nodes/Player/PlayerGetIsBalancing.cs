/*
 * Filename: PlayerGetIsBalancing.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the player is playing the balance animation
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Balancing (bool) - Whether the given player is playing the balance animation
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("6e1d8c6a-b4f9-4bca-a1e2-42084412d835")]
public class PlayerGetIsBalancing : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Balancing";
    public string GetVariableQualifiedName() => "playerGetIsBalancing";
}