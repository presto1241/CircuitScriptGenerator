/*
 * Filename: GameAISetIsVoiceOutputEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enables or disables the AI’s spoken responses.

Subtitles will be shown unless they are explicitly turned off.
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

[Node("629b36e0-cd10-4542-a667-2b1add0c3229")]
public class GameAISetIsVoiceOutputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Set Is Voice Output Enabled";
    public string GetVariableQualifiedName() => "gameAISetIsVoiceOutputEnabled";
}