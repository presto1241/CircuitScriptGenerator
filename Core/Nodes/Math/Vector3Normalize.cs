/*
 * Filename: Vector3Normalize.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the target vector, but its magnitude is 1.
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

[Node("92ded211-17d6-4c73-b29c-71323c6a40ee")]
public class Vector3Normalize : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Normalize";
    public string GetVariableQualifiedName() => "vector3Normalize";
}