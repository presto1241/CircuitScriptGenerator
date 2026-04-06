/*
 * Filename: PlayerPromptText.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a prompt to the specified player where they can input text, which is then returned by this chip's output. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Prompt Title (string)
 * Prompt Body (string)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Prompt Complete (exec)
 * Success (bool)
 * Receiving Player (Player)
 * Response (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("da8c6b01-2f4c-4d5b-88b5-293e4682fcc9")]
public class PlayerPromptText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Prompt Text";
    public string GetVariableQualifiedName() => "playerPromptText";
}