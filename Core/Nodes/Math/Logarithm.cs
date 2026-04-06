/*
 * Filename: Logarithm.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a logarithm.
 * Types: 
 * 
 * INPUTS: 
 * Value (float)
 * Base (float)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("28a105ab-a947-4493-a51d-ced76a9601ee")]
public class Logarithm : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Logarithm";
    public string GetVariableQualifiedName() => "logarithm";
}