/*
 * Filename: PlayerSetAirControlPercentage.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the fraction from 0 to 1 of the standard air control that this player will have. 
This is multiplied by the air control value for the user's current state to calculate their acceleration. 
Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Air Control Percentage (float) - Fraction from 0 to 1 of the standard air control
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("9fa0e65c-36f4-4c4e-969f-94ff82b35c99")]
public class PlayerSetAirControlPercentage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Air Control Percentage";
    public string GetVariableQualifiedName() => "playerSetAirControlPercentage";
}