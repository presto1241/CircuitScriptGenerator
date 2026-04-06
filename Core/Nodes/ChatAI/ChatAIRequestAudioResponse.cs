/*
 * Filename: ChatAIRequestAudioResponse.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Requests an audio response from a Chat AI
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Chat AI (Chat AI)
 * Audio Player (Audio Player)
 * AI Model (string)
 * Wackiness (float)
 * Voice Option (string)
 * Should Wait for Audio (bool)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response or Audio Finished (exec)
 * Success (bool)
 * Response Text (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("69d2f9d6-769d-4d86-b38a-7951ddeabc43")]
public class ChatAIRequestAudioResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Request Audio Response";
    public string GetVariableQualifiedName() => "chatAIRequestAudioResponse";
}