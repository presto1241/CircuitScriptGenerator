/*
 * Filename: ChatAIVariable.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A variable to store a Chat AI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Chat AI)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Chat AI)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("1bc1b7b3-8040-4b9a-aded-bcf5cd5ba453")]
public class ChatAIVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Variable";
    public string GetVariableQualifiedName() => "chatAIVariable";
}