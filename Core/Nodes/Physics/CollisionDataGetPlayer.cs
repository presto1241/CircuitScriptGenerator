/*
 * Filename: CollisionDataGetPlayer.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets player of a collision data (or null for objects) returned from "Overlap Sphere" chip.
 * Types: 
 * 
 * INPUTS: 
 * Target (Collision Data)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("2729e8db-62d1-4f9e-b076-74f27cd43332")]
public class CollisionDataGetPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Collision Data Get Player";
    public string GetVariableQualifiedName() => "collisionDataGetPlayer";
}