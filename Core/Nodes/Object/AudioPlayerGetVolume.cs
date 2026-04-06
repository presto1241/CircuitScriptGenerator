/*
 * Filename: AudioPlayerGetVolume.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the volume multiplier of the target Audio Player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * Volume (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("1bbabac2-f316-4e07-9eb6-fd65848a5b90")]
public class AudioPlayerGetVolume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Get Volume";
    public string GetVariableQualifiedName() => "audioPlayerGetVolume";
}