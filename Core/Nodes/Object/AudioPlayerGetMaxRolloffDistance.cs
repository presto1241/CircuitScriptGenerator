/*
 * Filename: AudioPlayerGetMaxRolloffDistance.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the furthest distance from the target Audio Player that the audio can be heard from.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * Max Rolloff Distance (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("2db28fb7-0edb-4f09-8d74-ed5614dfaf11")]
public class AudioPlayerGetMaxRolloffDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Get Max Rolloff Distance";
    public string GetVariableQualifiedName() => "audioPlayerGetMaxRolloffDistance";
}