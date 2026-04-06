/*
 * Filename: And.cs
 * Category: Logic
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True when all inputs are True. If any input is False, it outputs False.
 * Types: 
 * 
 * INPUTS: 
 * Input (bool)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Logic;

[Node("3fb9fd93-8d45-4395-b9a3-63a99a14442b")]
public class And : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "And";
    public string GetVariableQualifiedName() => "and";
}