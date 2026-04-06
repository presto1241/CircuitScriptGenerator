/*
 * Filename: CollisionDataGetNormal.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets unit vector specifying the direction of an object/player from center specified in "Overlap Sphere" chip.
 * Types: 
 * 
 * INPUTS: 
 * Target (Collision Data)
 *
 * OUTPUTS: 
 * Normal (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("ced470f8-dd9d-4e67-a654-7c7e1a3e7819")]
public class CollisionDataGetNormal : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Collision Data Get Normal";
    public string GetVariableQualifiedName() => "collisionDataGetNormal";
}