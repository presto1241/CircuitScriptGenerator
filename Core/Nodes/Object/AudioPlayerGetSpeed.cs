/*
 * Filename: AudioPlayerGetSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the speed multiplier of the target Audio Player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * Speed (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("931ebb4f-3424-4aa3-bee3-5e039ba210e4")]
public class AudioPlayerGetSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Get Speed";
    public string GetVariableQualifiedName() => "audioPlayerGetSpeed";
}