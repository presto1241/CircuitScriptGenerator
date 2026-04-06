/*
 * Filename: SharedGameAIGetSingleSpeakerModeAudioThreshold.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the minimum audio threshold for Single Speaker Mode.
 * Types: 
 * 
 * INPUTS: 
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("c9d23f3a-83e4-4c22-bd15-5999e44862de")]
public class SharedGameAIGetSingleSpeakerModeAudioThreshold : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Shared Game AI Get Single Speaker Mode Audio Threshold";
    public string GetVariableQualifiedName() => "sharedGameAIGetSingleSpeakerModeAudioThreshold";
}