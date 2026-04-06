/*
 * Filename: PlayAudioAtPosition.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Plays audio a single time at a specified position. Setting the volume and playback speed provide multipliers on the base volume and speed of the audio being played. Setting Is2D to true will ignore the position and play the sound without a spatial position.
 * Types: 
 * 
 * INPUTS: 
 * Play (exec)
 * Audio (Audio)
 * Position (Vector3)
 * Volume (float)
 * Playback Speed (float)
 * Is 2D (bool)
 *
 * OUTPUTS: 
 * Play (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("9b26c819-856c-4678-a3dc-db070ba492cc")]
public class PlayAudioAtPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Play Audio At Position";
    public string GetVariableQualifiedName() => "playAudioAtPosition";
}