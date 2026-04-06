/*
 * Filename: AudioPlayerGetTimeStamp.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the current time stamp of the target Audio Player in seconds.
 * Types: 
 * 
 * INPUTS: 
 * Target (Audio Player)
 *
 * OUTPUTS: 
 * Time Stamp (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("61e8293d-5d5a-4dbc-9505-0a13faf8b4cc")]
public class AudioPlayerGetTimeStamp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Player Get Time Stamp";
    public string GetVariableQualifiedName() => "audioPlayerGetTimeStamp";
}