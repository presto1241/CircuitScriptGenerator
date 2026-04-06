/*
 * Filename: PlayerCanReceiveTextPrompt.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the player can be targeted by a Player Prompt Text node
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Can Receive Text Prompt (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("02cddc65-3da7-48a3-b10e-ca260dcbf50a")]
public class PlayerCanReceiveTextPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Can Receive Text Prompt";
    public string GetVariableQualifiedName() => "playerCanReceiveTextPrompt";
}