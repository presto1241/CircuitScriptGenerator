/*
 * Filename: CollisionDataGetPosition.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets position of an object/player returned by "Overlap Sphere" chip.
 * Types: 
 * 
 * INPUTS: 
 * Target (Collision Data)
 *
 * OUTPUTS: 
 * Position (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("5910618b-f862-49ce-9779-46130e47f985")]
public class CollisionDataGetPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Collision Data Get Position";
    public string GetVariableQualifiedName() => "collisionDataGetPosition";
}