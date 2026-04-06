/*
 * Filename: SharedGameAISetSingleSpeakerModeAudioThreshold.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the minimum audio threshold for Single Speaker mode in Shared Game AI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Value (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("997923db-d2f1-4905-aa4c-4bbb5c06a8e0")]
public class SharedGameAISetSingleSpeakerModeAudioThreshold : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Shared Game AI Set Single Speaker Mode Audio Threshold";
    public string GetVariableQualifiedName() => "sharedGameAISetSingleSpeakerModeAudioThreshold";
}