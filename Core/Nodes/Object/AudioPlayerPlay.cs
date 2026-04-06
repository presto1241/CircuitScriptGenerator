/*
 * Filename: AudioPlayerPlay.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Play the specified Audio clip using the target Audio Player
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Audio Player)
 * Audio (Audio)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("38f16370-7224-40d0-a551-665bb9fb6f8b")]
public class AudioPlayerPlay : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Play";
    public string GetVariableQualifiedName() => "audioPlayerPlay";
}