/*
 * Filename: SharedGameAISetIsSingleSpeakerModeEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether or not the Shared Game AI is in Single Speaker Mode.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Value (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("2f5b9481-d2d1-47f3-8989-f26f30d96391")]
public class SharedGameAISetIsSingleSpeakerModeEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Shared Game AI Set Is Single Speaker Mode Enabled";
    public string GetVariableQualifiedName() => "sharedGameAISetIsSingleSpeakerModeEnabled";
}