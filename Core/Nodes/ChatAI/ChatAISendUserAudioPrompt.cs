/*
 * Filename: ChatAISendUserAudioPrompt.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a user audio prompt to a Chat AI.

User prompts are issued from the user's perspective and represent conversational input or commands directed at the AI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Chat AI (Chat AI)
 * Audio Recording Prompt (Audio Recording)
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

[Node("7bfb021b-e3a5-4222-9bac-7500bdeb6135")]
public class ChatAISendUserAudioPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Send User Audio Prompt";
    public string GetVariableQualifiedName() => "chatAISendUserAudioPrompt";
}