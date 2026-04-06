/*
 * Filename: ActiveAudioRecording.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: An Audio Constant node that stores recordable audio.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Active Audio Recording)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8d3d7784-f07e-483a-a71c-1f3e767ec73c")]
public class ActiveAudioRecording : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Active Audio Recording";
    public string GetVariableQualifiedName() => "activeAudioRecording";
}