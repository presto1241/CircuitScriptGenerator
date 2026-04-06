/*
 * Filename: ListChatAIVariable.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A variable to store a list of Chat AI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Chat AI>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Chat AI>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("e942fe79-d2c1-47da-94a3-c48a15aa09ca")]
public class ListChatAIVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Chat AI> Variable";
    public string GetVariableQualifiedName() => "listChatAIVariable";
}