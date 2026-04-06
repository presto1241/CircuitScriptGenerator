/*
 * Filename: Vector3Transform.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Transforms a point from local space to world space. LocalPoint is the point you want to transform, WorldOrigin is the describes where the local coordinate system is located in the world, and WorldOrientation is the rotation of the local coordinate system.
 * Types: 
 * 
 * INPUTS: 
 * LocalPoint (Vector3)
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

[Node("64924217-da3a-4a6f-b84d-e499634d763b")]
public class Vector3Transform : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Transform";
    public string GetVariableQualifiedName() => "vector3Transform";
}