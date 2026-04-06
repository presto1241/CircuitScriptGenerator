/*
 * Filename: Vector3InverseTransform.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Transforms a point from world space into local space.
 * Types: 
 * 
 * INPUTS: 
 * WorldPoint (Vector3)
 * WorldOrigin (Vector3)
 * WorldOrientation (Quaternion)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("97b150f5-7bd0-4649-96d7-fdf0b5e88ffb")]
public class Vector3InverseTransform : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Inverse Transform";
    public string GetVariableQualifiedName() => "vector3InverseTransform";
}