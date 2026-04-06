/*
 * Filename: Root.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Calculate the root of a given value, with the default root being 2 (meaning the square root).
 * Types: 
 * 
 * INPUTS: 
 * Value (float)
 * Root (float)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("8b96e472-2b19-4265-aade-2c6202358d86")]
public class Root : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Root";
    public string GetVariableQualifiedName() => "root";
}