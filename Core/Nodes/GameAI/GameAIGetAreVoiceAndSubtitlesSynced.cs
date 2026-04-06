/*
 * Filename: GameAIGetAreVoiceAndSubtitlesSynced.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether all players can hear the AI’s voice responses.
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

[Node("73622d97-3b34-4d5a-80c3-4c47fcc6cbc2")]
public class GameAIGetAreVoiceAndSubtitlesSynced : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Are Voice And Subtitles Synced";
    public string GetVariableQualifiedName() => "gameAIGetAreVoiceAndSubtitlesSynced";
}