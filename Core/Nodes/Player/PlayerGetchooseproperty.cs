/*
 * Filename: PlayerGetchooseproperty.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value of the configured property on a given player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("57ec543e-9e17-4f24-a091-0cc7e175dcd4")]
public class PlayerGetchooseproperty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get (choose property)";
    public string GetVariableQualifiedName() => "playerGetchooseproperty";
}