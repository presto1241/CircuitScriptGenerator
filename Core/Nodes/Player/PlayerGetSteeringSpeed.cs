/*
 * Filename: PlayerGetSteeringSpeed.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the steering speed requested by the player. This value represents how fast a player is wanting to move in world units.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Steering Speed (float) - How fast the given player wants to move in m/s
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("348bc4c8-3b3b-4c44-8c49-4f782e5c8039")]
public class PlayerGetSteeringSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Steering Speed";
    public string GetVariableQualifiedName() => "playerGetSteeringSpeed";
}