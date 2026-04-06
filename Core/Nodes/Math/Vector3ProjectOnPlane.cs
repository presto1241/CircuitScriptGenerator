/*
 * Filename: Vector3ProjectOnPlane.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Projects a vector onto a plane
 * Types: 
 * 
 * INPUTS: 
 * Vector (Vector3)
 * Plane Normal (Vector3)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("f874d150-7d49-4f10-ac51-50dd9bd29c4f")]
public class Vector3ProjectOnPlane : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Project On Plane";
    public string GetVariableQualifiedName() => "vector3ProjectOnPlane";
}