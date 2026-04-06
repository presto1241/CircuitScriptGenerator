/*
 * Filename: QuaternionInverse.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the Inverse of rotation.
 * Types: 
 * 
 * INPUTS: 
 * Value (Quaternion)
 *
 * OUTPUTS: 
 * Result (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("2097bef3-9ed1-4601-ab5d-f620654bd1c4")]
public class QuaternionInverse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Inverse";
    public string GetVariableQualifiedName() => "quaternionInverse";
}