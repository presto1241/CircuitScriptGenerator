/*
 * Filename: Min.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns smallest of two or more values.
 * Types: (int | float)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Min (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("bfb1ad17-5ade-4bd8-9c31-6d4b1e47dae3")]
public class Min : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Min";
    public string GetVariableQualifiedName() => "min";
}