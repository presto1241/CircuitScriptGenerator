/*
 * Filename: PlayerGetPhysicsVelocity.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the physics velocity for the given player. 
Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources 
Physics velocity will generally be reduced over time by drag from various sources.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Physics Velocity (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("12a87d99-c45a-48e3-b2e5-308ce3e51199")]
public class PlayerGetPhysicsVelocity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Physics Velocity";
    public string GetVariableQualifiedName() => "playerGetPhysicsVelocity";
}