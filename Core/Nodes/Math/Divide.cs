/*
 * Filename: Divide.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Find how many times a value contains another.
 * Types: (int | float | Vector3)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Quotient (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("f2eafd78-5f23-44c9-a271-8ff2f0762e71")]
public class Divide : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Divide";
    public string GetVariableQualifiedName() => "divide";
}