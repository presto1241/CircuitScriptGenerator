/*
 * Filename: GameAISetAreVoiceAndSubtitlesSynced.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether the AI’s voice responses are audible to all players.
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

[Node("2c814e8f-c756-411c-ad4b-1c2c02615aa9")]
public class GameAISetAreVoiceAndSubtitlesSynced : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Set Are Voice And Subtitles Synced";
    public string GetVariableQualifiedName() => "gameAISetAreVoiceAndSubtitlesSynced";
}