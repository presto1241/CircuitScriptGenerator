/*
 * Filename: InttoFloat.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Converts the input int to a float.
 * Types: 
 * 
 * INPUTS: 
 * Value (int)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("65cfba8a-b5dc-4946-b824-e6efc5719f3a")]
public class InttoFloat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Int to Float";
    public string GetVariableQualifiedName() => "inttoFloat";
}