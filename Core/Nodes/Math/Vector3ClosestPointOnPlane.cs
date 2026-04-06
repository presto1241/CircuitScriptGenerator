/*
 * Filename: Vector3ClosestPointOnPlane.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the point on the plane that is closest to a given position
 * Types: 
 * 
 * INPUTS: 
 * Position (Vector3) - Position to get closest to
 * Plane Position (Vector3) - Any point on the plane
 * Plane Normal (Vector3)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("abb84e7e-c879-4744-8f29-5392f975d8a0")]
public class Vector3ClosestPointOnPlane : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Closest Point On Plane";
    public string GetVariableQualifiedName() => "vector3ClosestPointOnPlane";
}