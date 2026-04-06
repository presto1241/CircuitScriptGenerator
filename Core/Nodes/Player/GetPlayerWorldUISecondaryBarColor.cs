/*
 * Filename: GetPlayerWorldUISecondaryBarColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of the given player's secondary bar in their current world UI.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("2e537d07-930e-44f6-8757-ff34c365fd06")]
public class GetPlayerWorldUISecondaryBarColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Secondary Bar Color";
    public string GetVariableQualifiedName() => "getPlayerWorldUISecondaryBarColor";
}