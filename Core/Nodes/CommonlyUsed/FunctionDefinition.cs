/*
 * Filename: FunctionDefinition.cs
 * Category: Commonly Used
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Defines a function.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * 
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.CommonlyUsed;

[Node("49937daa-4f6d-442c-a0d8-0095b675250d")]
public class FunctionDefinition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Function Definition";
    public string GetVariableQualifiedName() => "functionDefinition";
}