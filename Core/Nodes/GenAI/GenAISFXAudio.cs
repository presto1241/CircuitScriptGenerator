/*
 * Filename: GenAISFXAudio.cs
 * Category: Gen AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Generate and store custom Gen AI sfx for use with the Audio Player.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Audio)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GenAI;

[Node("f3dc2f56-e323-4035-8776-2d040b294fee")]
public class GenAISFXAudio : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Gen AI SFX Audio";
    public string GetVariableQualifiedName() => "genAISFXAudio";
}