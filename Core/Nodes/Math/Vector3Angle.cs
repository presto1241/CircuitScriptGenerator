/*
 * Filename: Vector3Angle.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes the angle between two vectors
 * Types: 
 * 
 * INPUTS: 
 * Lhs (Vector3)
 * Rhs (Vector3)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("2f0f7b90-3270-4db0-8266-cf48aa201ec7")]
public class Vector3Angle : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Angle";
    public string GetVariableQualifiedName() => "vector3Angle";
}