/*
 * Filename: AudioPlayerSetSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the speed multiplier that the target Audio Player will play at.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Audio Player)
 * Speed (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a59e93b4-f949-47b4-af73-fb6e110392fa")]
public class AudioPlayerSetSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Set Speed";
    public string GetVariableQualifiedName() => "audioPlayerSetSpeed";
}