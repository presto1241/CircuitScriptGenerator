/*
 * Filename: ChatAIRequestTextResponse.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Requests a text response from a Chat AI
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Chat AI (Chat AI)
 * AI Model (string)
 * Wackiness (float)
 * Functions (List<AI Function>)
 * Must Call Function (bool)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response (exec)
 * Success (bool)
 * Response Text (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("67e19dc2-75ff-4b3b-8df6-553ed013ab7c")]
public class ChatAIRequestTextResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Request Text Response";
    public string GetVariableQualifiedName() => "chatAIRequestTextResponse";
}