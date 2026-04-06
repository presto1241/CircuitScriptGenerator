/*
 * Filename: CollisionDataGetDistance.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets distance in meters of an object/player from center specified in "Overlap Sphere" chip.
 * Types: 
 * 
 * INPUTS: 
 * Target (Collision Data)
 *
 * OUTPUTS: 
 * Distance (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("c3fc963c-6d73-4d88-9c9b-95e9faae219f")]
public class CollisionDataGetDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Collision Data Get Distance";
    public string GetVariableQualifiedName() => "collisionDataGetDistance";
}