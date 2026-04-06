/*
 * Filename: OverlapSphere.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get information about all the objects/players within a certain distance of a point in space (position, distance, direction, etc.)
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Origin (Vector3)
 * Radius (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Collisions (List<Collision Data>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("23ce1dae-7585-43af-92c1-9a72fa5d0101")]
public class OverlapSphere : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Overlap Sphere";
    public string GetVariableQualifiedName() => "overlapSphere";
}