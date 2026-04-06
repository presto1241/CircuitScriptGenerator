/*
 * Filename: GameAIRequestSetVoiceAndClearContext.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the voice for the Game AI, which requires clearing the conversation
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Value (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Cleared (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("eece1a8e-103a-4666-b9a8-b04e626f993f")]
public class GameAIRequestSetVoiceAndClearContext : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Request Set Voice And Clear Context";
    public string GetVariableQualifiedName() => "gameAIRequestSetVoiceAndClearContext";
}