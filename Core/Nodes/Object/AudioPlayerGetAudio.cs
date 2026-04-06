/*
 * Filename: AudioPlayerGetAudio.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the most recent audio reference that the target Audio Player has started playing.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * Audio (Audio)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0f4433b6-425d-4172-968a-2c867bc0fef5")]
public class AudioPlayerGetAudio : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Get Audio";
    public string GetVariableQualifiedName() => "audioPlayerGetAudio";
}