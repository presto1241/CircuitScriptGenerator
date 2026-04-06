/*
 * Filename: Vector3ClampMagnitude.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clamps a vector's magnitude to a given max length.
Vector is unchanged if magnitude is already less.
Max length cannot be negative.
 * Types: 
 * 
 * INPUTS: 
 * Vector (Vector3)
 * Max Length (float)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("c12ba6c4-51f6-478c-96a7-b989dbe6df80")]
public class Vector3ClampMagnitude : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Clamp Magnitude";
    public string GetVariableQualifiedName() => "vector3ClampMagnitude";
}