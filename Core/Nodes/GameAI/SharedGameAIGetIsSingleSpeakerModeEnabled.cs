/*
 * Filename: SharedGameAIGetIsSingleSpeakerModeEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the Shared Game AI has Single Speaker Mode enabled.
 * Types: 
 * 
 * INPUTS: 
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Value (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("2bc4915e-639b-4820-bd2a-8da96e92b211")]
public class SharedGameAIGetIsSingleSpeakerModeEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Shared Game AI Get Is Single Speaker Mode Enabled";
    public string GetVariableQualifiedName() => "sharedGameAIGetIsSingleSpeakerModeEnabled";
}