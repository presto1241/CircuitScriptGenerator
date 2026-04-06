/*
 * Filename: TextToSpeech.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Speaks generated audio from input text using the specified voice and instructions for how the voice should read the text. The audio is output at the provided position for 3D text, with optional subtitles.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Text (string)
 * Voice (string)
 * Instructions (string)
 * Position (Vector3)
 * Is 2D (bool)
 * Show Subtitles (bool)
 * Use Context (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Audio Finished (exec)
 * Success (bool)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("47703f0c-2388-4441-90f0-26e69c6c235a")]
public class TextToSpeech : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Text To Speech";
    public string GetVariableQualifiedName() => "textToSpeech";
}