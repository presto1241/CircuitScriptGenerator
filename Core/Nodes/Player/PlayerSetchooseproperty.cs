/*
 * Filename: PlayerSetchooseproperty.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the value of the configured property on a given player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a6ca3925-3c7f-4960-899f-6d94557a4e21")]
public class PlayerSetchooseproperty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set (choose property)";
    public string GetVariableQualifiedName() => "playerSetchooseproperty";
}