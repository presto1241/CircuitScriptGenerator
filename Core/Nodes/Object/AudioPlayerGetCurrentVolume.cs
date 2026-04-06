/*
 * Filename: AudioPlayerGetCurrentVolume.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current volume of the audio being played by the target Audio Player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * Current Volume (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3ea6c1c5-7f44-43d1-a424-f029a67c60c8")]
public class AudioPlayerGetCurrentVolume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Get Current Volume";
    public string GetVariableQualifiedName() => "audioPlayerGetCurrentVolume";
}