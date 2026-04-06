/*
 * Filename: ChatAISendSystemPrompt.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a system prompt to a Chat AI.

System prompts are issued from the AI’s perspective, not the user’s, and are intended as contextual observations or directives rather than conversational dialogue. Think of them as the AI’s thoughts.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Chat AI (Chat AI)
 * Prompt (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Sent (exec)
 * Success (bool)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("afc86e37-5179-4925-8489-eeae41b0f54b")]
public class ChatAISendSystemPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Send System Prompt";
    public string GetVariableQualifiedName() => "chatAISendSystemPrompt";
}