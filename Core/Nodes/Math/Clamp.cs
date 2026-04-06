/*
 * Filename: Clamp.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clamps a value between a minimum value and maximum value. If the minimum is greater than the maximum, the minimum value will always be returned no matter the input.
 * Types: (float | int)
 * 
 * INPUTS: 
 * Value (T)
 * Min (T)
 * Max (T)
 *
 * OUTPUTS: 
 * Result (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("f95735f1-1db8-4bf4-8198-03b2595fa741")]
public class Clamp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Clamp";
    public string GetVariableQualifiedName() => "clamp";
}