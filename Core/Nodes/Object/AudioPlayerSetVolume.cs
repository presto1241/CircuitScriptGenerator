/*
 * Filename: AudioPlayerSetVolume.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the volume multiplier that the target Audio Player will play at.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Audio Player)
 * Volume (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("cdedf5fe-9d4f-4811-9883-160b04695657")]
public class AudioPlayerSetVolume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Set Volume";
    public string GetVariableQualifiedName() => "audioPlayerSetVolume";
}