/*
 * Filename: PlayerGetIsSliding.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the given player is sliding.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Sliding (bool) - Whether the given player is sliding.
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a6bf14e7-5f67-415e-b1c0-67adc223b01e")]
public class PlayerGetIsSliding : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Sliding";
    public string GetVariableQualifiedName() => "playerGetIsSliding";
}