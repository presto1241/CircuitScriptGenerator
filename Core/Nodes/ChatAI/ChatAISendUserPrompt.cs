/*
 * Filename: ChatAISendUserPrompt.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a user prompt to a Chat AI.

User prompts are issued from the user's perspective and represent conversational input or commands directed at the AI.
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

[Node("478eb7c4-5944-41f5-880e-e45d5b9c9c66")]
public class ChatAISendUserPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Send User Prompt";
    public string GetVariableQualifiedName() => "chatAISendUserPrompt";
}