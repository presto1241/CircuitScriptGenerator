/*
 * Filename: PlayerGetAirControlPercentage.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the fraction from 0 to 1 of the standard air control that this player has. 
This is multiplied by the air control value for the user's current state to calculate their acceleration. 
Set velocity nodes, wall running, wall climbing, and jumping out of a slide also affect your acceleration.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Air Control Percentage (float) - Fraction from 0 to 1 of the standard air control
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("5d432b27-fe6d-49d0-a3cc-f013a4443bb1")]
public class PlayerGetAirControlPercentage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Air Control Percentage";
    public string GetVariableQualifiedName() => "playerGetAirControlPercentage";
}