/*
 * Filename: Subtract.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Takes one input value away from the other.
 * Types: (int | float | Vector3)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Difference (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("1fbb364c-1af0-44bb-a82b-905caeb6819a")]
public class Subtract : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Subtract";
    public string GetVariableQualifiedName() => "subtract";
}