/*
 * Filename: ChatAIModel.cs
 * Category: Chat AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Provides the list of supported Chat AI models.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ChatAI;

[Node("1ef1811c-ea13-4b41-839a-9575fe361380")]
public class ChatAIModel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Chat AI Model";
    public string GetVariableQualifiedName() => "chatAIModel";
}