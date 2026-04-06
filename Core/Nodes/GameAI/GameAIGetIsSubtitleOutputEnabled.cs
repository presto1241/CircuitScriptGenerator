/*
 * Filename: GameAIGetIsSubtitleOutputEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether subtitles are currently enabled or disabled for the AI.
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

[Node("85c5245f-2b3c-4d86-b0cd-83e0192df81c")]
public class GameAIGetIsSubtitleOutputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Is Subtitle Output Enabled";
    public string GetVariableQualifiedName() => "gameAIGetIsSubtitleOutputEnabled";
}