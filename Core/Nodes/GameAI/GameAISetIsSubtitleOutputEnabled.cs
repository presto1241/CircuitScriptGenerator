/*
 * Filename: GameAISetIsSubtitleOutputEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enables or disables subtitle display for the AI.

Response text will still be available through string response ports regardless of subtitle settings.
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

[Node("b27e6514-3455-4959-aa62-8cdcaa93e1be")]
public class GameAISetIsSubtitleOutputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Set Is Subtitle Output Enabled";
    public string GetVariableQualifiedName() => "gameAISetIsSubtitleOutputEnabled";
}