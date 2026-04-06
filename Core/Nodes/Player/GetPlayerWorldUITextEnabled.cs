/*
 * Filename: GetPlayerWorldUITextEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the enabled state of the given player's text in their current world UI.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("cd1b799d-855a-4ade-b62f-043a0db60a44")]
public class GetPlayerWorldUITextEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Text Enabled";
    public string GetVariableQualifiedName() => "getPlayerWorldUITextEnabled";
}