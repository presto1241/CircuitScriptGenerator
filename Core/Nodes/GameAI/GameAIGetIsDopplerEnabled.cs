/*
 * Filename: GameAIGetIsDopplerEnabled.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the Doppler effect is currently enabled for the AI’s voice.
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

[Node("d50b60af-4f1d-4d20-9ba5-b0a9285cbad6")]
public class GameAIGetIsDopplerEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Is Doppler Enabled";
    public string GetVariableQualifiedName() => "gameAIGetIsDopplerEnabled";
}