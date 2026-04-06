/*
 * Filename: PlayerGetIsSprinting.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the given player is sprinting.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Sprinting (bool) - Whether the given player is sprinting.
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("52544269-fc72-4b7e-97eb-23d9b84af1e2")]
public class PlayerGetIsSprinting : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Sprinting";
    public string GetVariableQualifiedName() => "playerGetIsSprinting";
}