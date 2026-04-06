/*
 * Filename: Vector3Inverse.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Multiplies a vector by -1 to get its inverse.
 * Types: 
 * 
 * INPUTS: 
 * Value (Vector3)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("429fc835-d971-48fd-a030-d8f7d5a96437")]
public class Vector3Inverse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Inverse";
    public string GetVariableQualifiedName() => "vector3Inverse";
}