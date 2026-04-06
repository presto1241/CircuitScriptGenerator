/*
 * Filename: AudioPlayerGetPlaying.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if the target Audio Player is playing.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * Playing (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("00443d01-632e-4f75-ac6f-23b3e224e791")]
public class AudioPlayerGetPlaying : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Get Playing";
    public string GetVariableQualifiedName() => "audioPlayerGetPlaying";
}