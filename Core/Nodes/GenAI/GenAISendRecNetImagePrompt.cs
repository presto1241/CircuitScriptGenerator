/*
 * Filename: GenAISendRecNetImagePrompt.cs
 * Category: Gen AI
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Sends a prompt with a RecNet-hosted image to a Gen AI model and returns a text response.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Prompt (string)
 * RecNet Image (RecNet Image)
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

namespace CircuitScriptGenerator.Core.Nodes.Gen AI;

[Node("08d17d83-d09a-4d44-81b1-c26670eef0e3")]
public class GenAISendRecNetImagePrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gen AI Send RecNet Image Prompt";
    public string GetVariableQualifiedName() => "genAISendRecNetImagePrompt";
}