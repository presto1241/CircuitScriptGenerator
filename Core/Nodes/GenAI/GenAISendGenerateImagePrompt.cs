/*
 * Filename: GenAISendGenerateImagePrompt.cs
 * Category: Gen AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Generates an image using a Gen AI model based on a text prompt. If Does Tile is enabled, a seamless tiling image is produced.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Prompt (string)
 * Texture (Texture)
 * Does Tile (bool)
 * AI Model (string)
 * Use Context (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Generated (exec)
 * Success (bool)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GenAI;

[Node("bf56ccdd-46c7-4105-a9ea-0455f488725d")]
public class GenAISendGenerateImagePrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gen AI Send Generate Image Prompt";
    public string GetVariableQualifiedName() => "genAISendGenerateImagePrompt";
}