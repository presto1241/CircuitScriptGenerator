/*
 * Filename: Vector3Dot.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes the dot product. Commonly used to determine if the camera is facing a particular direction.
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

[Node("498c4e25-f73b-49a6-912e-ae148ed50dca")]
public class Vector3Dot : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Dot";
    public string GetVariableQualifiedName() => "vector3Dot";
}