/*
 * Filename: ChatAIRequestStructuredResponse.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Generates data in the provided format. Use the prompt and port descriptions to guide the AI on how to populate each value.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Chat AI (Chat AI)
 * Description (string)
 * AI Model (string)
 * Wackiness (float)
 * Functions (List<AI Function>)
 * Must Call Function (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Completed (exec)
 * Success (bool)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("c9e56952-b64d-49ef-b564-a38c1695eeb6")]
public class ChatAIRequestStructuredResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Request Structured Response";
    public string GetVariableQualifiedName() => "chatAIRequestStructuredResponse";
}