/*
 * Filename: OverlapBox.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get information about all the objects/players within a box defined by its center, extents, and orientation. (position, distance, direction, etc.)
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Center (Vector3)
 * Extents (Vector3)
 * Orientation (Quaternion)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Collisions (List<Collision Data>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("5df93bc7-4bb7-44c6-b260-d7b2836436c8")]
public class OverlapBox : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Overlap Box";
    public string GetVariableQualifiedName() => "overlapBox";
}