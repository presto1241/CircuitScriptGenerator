/*
 * Filename: PlayerSetCanWallRun.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the whether the player can Wall Run. Enforced via circuits.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Wall Run Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("8470f76b-a4c5-4b79-9651-5af1b9ed8b78")]
public class PlayerSetCanWallRun : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Can Wall Run";
    public string GetVariableQualifiedName() => "playerSetCanWallRun";
}