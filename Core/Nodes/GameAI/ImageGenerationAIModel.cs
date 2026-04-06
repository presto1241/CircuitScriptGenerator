/*
 * Filename: ImageGenerationAIModel.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Provides the list of supported Image Generation AI models.
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

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("1a800359-1bcd-42d8-a1b9-b608539c96ed")]
public class ImageGenerationAIModel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Image Generation AI Model";
    public string GetVariableQualifiedName() => "imageGenerationAIModel";
}