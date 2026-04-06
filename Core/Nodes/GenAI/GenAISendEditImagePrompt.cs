/*
 * Filename: GenAISendEditImagePrompt.cs
 * Category: Gen AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Edits an image using a Gen AI model based on a text prompt. The modified image is stored on RecNet.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Prompt (string)
 * Texture (Texture)
 * AI Model (string)
 * Use Context (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response (exec)
 * Success (bool)
 * RecNet Image (RecNet Image)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GenAI;

[Node("274babb5-9ce4-4a49-a50a-12581facde68")]
public class GenAISendEditImagePrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gen AI Send Edit Image Prompt";
    public string GetVariableQualifiedName() => "genAISendEditImagePrompt";
}