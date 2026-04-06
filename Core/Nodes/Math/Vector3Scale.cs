/*
 * Filename: Vector3Scale.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Multiplies a vector by a scalar.
 * Types: (int | float)
 * 
 * INPUTS: 
 * Value (Vector3)
 * Scalar (T)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("87aa17b1-7760-4b07-8c44-a2d530590597")]
public class Vector3Scale : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Scale";
    public string GetVariableQualifiedName() => "vector3Scale";
}