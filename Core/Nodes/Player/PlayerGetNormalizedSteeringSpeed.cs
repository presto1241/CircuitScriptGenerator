/*
 * Filename: PlayerGetNormalizedSteeringSpeed.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: (DEPRECATED: Use PlayerGetSteeringSpeed / GetWalkSpeed) Returns the steering speed requested by the player, squared, and normalized by the square of the default walk speed.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Normalized Steering Speed (float) - How fast the given player wants to move relative to their max speed (value is normalized between zero and one).
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("1eb70662-4a75-4120-9713-11dbbeedc740")]
public class PlayerGetNormalizedSteeringSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Normalized Steering Speed";
    public string GetVariableQualifiedName() => "playerGetNormalizedSteeringSpeed";
}