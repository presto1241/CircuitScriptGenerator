/*
 * Filename: AudioPlayerStop.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stop playback on the target Audio Player. "Play" will resume from the beginning
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f6c546cc-becd-44cc-999b-bf2031b5f737")]
public class AudioPlayerStop : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Stop";
    public string GetVariableQualifiedName() => "audioPlayerStop";
}