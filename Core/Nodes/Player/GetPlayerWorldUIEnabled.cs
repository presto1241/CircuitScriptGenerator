/*
 * Filename: GetPlayerWorldUIEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the enabled state of the given player's world UI.
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

[Node("36ad6c98-0fb8-43a0-bf8d-0784394d2d28")]
public class GetPlayerWorldUIEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Enabled";
    public string GetVariableQualifiedName() => "getPlayerWorldUIEnabled";
}