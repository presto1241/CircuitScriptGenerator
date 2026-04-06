/*
 * Filename: EndLocalAudioRecordingNode.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Ends an audio recording for the local player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Active Audio Recording (Active Audio Recording)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Recording (Audio Recording)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8ef0ae99-bdf9-483c-a782-23f27f7eace9")]
public class EndLocalAudioRecordingNode : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "End Local Audio Recording Node";
    public string GetVariableQualifiedName() => "endLocalAudioRecordingNode";
}