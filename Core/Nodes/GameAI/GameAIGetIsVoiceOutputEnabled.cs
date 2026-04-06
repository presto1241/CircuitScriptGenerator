/*
 * Filename: GameAIGetIsVoiceOutputEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether voice output is currently enabled or disabled for the AI.
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

[Node("f0ec40d6-096a-4a43-ba5f-91928bc0f794")]
public class GameAIGetIsVoiceOutputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Is Voice Output Enabled";
    public string GetVariableQualifiedName() => "gameAIGetIsVoiceOutputEnabled";
}