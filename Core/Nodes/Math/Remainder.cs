/*
 * Filename: Remainder.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the remainder of the first value when divided by the second.
 * Types: (int | float)
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Remainder (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("fe462e79-9e9f-4234-b594-7b6c0a69329b")]
public class Remainder : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Remainder";
    public string GetVariableQualifiedName() => "remainder";
}