/*
 * Filename: GetPlayerWorldUISecondaryBarEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the enabled state of the given player's secondary bar in their current world UI.
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

[Node("eaddf07d-4beb-4841-990c-a6b674a66126")]
public class GetPlayerWorldUISecondaryBarEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Secondary Bar Enabled";
    public string GetVariableQualifiedName() => "getPlayerWorldUISecondaryBarEnabled";
}