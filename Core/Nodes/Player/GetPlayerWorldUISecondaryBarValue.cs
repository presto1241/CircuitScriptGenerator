/*
 * Filename: GetPlayerWorldUISecondaryBarValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value of the given player's secondary bar in their current world UI.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("cafb066f-d6f5-4a1a-a833-e1a0186c6d8e")]
public class GetPlayerWorldUISecondaryBarValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Secondary Bar Value";
    public string GetVariableQualifiedName() => "getPlayerWorldUISecondaryBarValue";
}