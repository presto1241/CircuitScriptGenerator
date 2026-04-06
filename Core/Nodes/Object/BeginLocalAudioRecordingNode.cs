/*
 * Filename: BeginLocalAudioRecordingNode.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Begins an audio recording for the local player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Active Audio Recording (Active Audio Recording)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("58b716f2-f397-4c17-aacb-8f4d803b569e")]
public class BeginLocalAudioRecordingNode : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Begin Local Audio Recording Node";
    public string GetVariableQualifiedName() => "beginLocalAudioRecordingNode";
}