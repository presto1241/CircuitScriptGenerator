/*
 * Filename: GenAISendImagePrompt.cs
 * Category: Gen AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a prompt along with an image to a Gen AI model and returns a text response.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Prompt (string)
 * Texture (Texture)
 * AI Model (string)
 * Wackiness (float)
 * Use Context (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response (exec)
 * Success (bool)
 * Response (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GenAI;

[Node("bfccce9a-a6a0-41ab-95c1-6c12d3c3473e")]
public class GenAISendImagePrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gen AI Send Image Prompt";
    public string GetVariableQualifiedName() => "genAISendImagePrompt";
}