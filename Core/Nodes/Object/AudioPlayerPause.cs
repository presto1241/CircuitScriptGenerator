/*
 * Filename: AudioPlayerPause.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Pause playback on the target Audio Player. "Play" will resume from the position at which the loaded clip was paused, unless the clip is changed
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

[Node("e6391f35-dd8b-4e99-a0f9-7dc44b6c1893")]
public class AudioPlayerPause : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Pause";
    public string GetVariableQualifiedName() => "audioPlayerPause";
}