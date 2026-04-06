/*
 * Filename: PlayerSetCrouchSpeed.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the crouch speed for a given player
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Crouch Speed (m/s) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("0a83ea9a-7796-4f77-940e-1bb6593b1ac2")]
public class PlayerSetCrouchSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Crouch Speed";
    public string GetVariableQualifiedName() => "playerSetCrouchSpeed";
}