/*
 * Filename: Multiply.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Multiplies the two or more input values and outputs the result.
 * Types: (int | float | Quaternion | Vector3)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Product (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("4738d696-d05a-42ee-a182-7641c429ae06")]
public class Multiply : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Multiply";
    public string GetVariableQualifiedName() => "multiply";
}