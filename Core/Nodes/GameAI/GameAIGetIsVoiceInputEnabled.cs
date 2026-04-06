/*
 * Filename: GameAIGetIsVoiceInputEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the AI is currently listening for player speech.
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

[Node("d55423dc-6836-45fa-9e5f-4e22d7a650a5")]
public class GameAIGetIsVoiceInputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Is Voice Input Enabled";
    public string GetVariableQualifiedName() => "gameAIGetIsVoiceInputEnabled";
}