/*
 * Filename: Add.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes the sum of two or more inputs.
 * Types: (int | float | Vector3)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Sum (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("0ccb153c-dd08-4f22-80fd-9d8c5940928c")]
public class Add : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Add";
    public string GetVariableQualifiedName() => "add";
}