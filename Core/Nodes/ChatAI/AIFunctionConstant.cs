/*
 * Filename: AIFunctionConstant.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A constant used to reference a Circuits Function which can be exposed to an AI.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (AI Function)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("ec0c9ad2-60e1-44bd-af0e-9146a009d073")]
public class AIFunctionConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Function Constant";
    public string GetVariableQualifiedName() => "aIFunctionConstant";
}