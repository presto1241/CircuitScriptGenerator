/*
 * Filename: PlayerSetPhysicsVelocity.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the physics velocity for the given player.  
Physics velocity includes velocity from impulses, jumps, vehicle collisions, and similar sources. 
Physics velocity will generally be reduced over time by drag from various sources. 
This node is similar Velocity Set. However, that node also zeroes the Steering Velocity.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Physics Velocity (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("b57b2efb-7ab5-47c0-808b-ac62651758c6")]
public class PlayerSetPhysicsVelocity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Physics Velocity";
    public string GetVariableQualifiedName() => "playerSetPhysicsVelocity";
}