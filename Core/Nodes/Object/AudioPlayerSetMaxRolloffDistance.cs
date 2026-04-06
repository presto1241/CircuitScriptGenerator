/*
 * Filename: AudioPlayerSetMaxRolloffDistance.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the maximum distance that audio from the target Audio Player can be heard from.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Audio Player)
 * Max Rolloff Distance (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c8b0ee69-7b27-4805-b809-438b1c59f472")]
public class AudioPlayerSetMaxRolloffDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Set Max Rolloff Distance";
    public string GetVariableQualifiedName() => "audioPlayerSetMaxRolloffDistance";
}