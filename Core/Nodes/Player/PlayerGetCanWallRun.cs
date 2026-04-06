/*
 * Filename: PlayerGetCanWallRun.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the whether the player can Wall Run. Enforced via circuits.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Wall Run Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("ae54528b-eaf4-4247-a49e-29b9acbaf1b5")]
public class PlayerGetCanWallRun : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Can Wall Run";
    public string GetVariableQualifiedName() => "playerGetCanWallRun";
}