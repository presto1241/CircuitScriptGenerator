/*
 * Filename: GameAIGetIsSpeaking.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true when the given Game AI component is outputting audio.
 * Types: 
 * 
 * INPUTS: 
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Is Speaking (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("682b417e-1a2d-4d6d-99c6-a1b100492b56")]
public class GameAIGetIsSpeaking : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Is Speaking";
    public string GetVariableQualifiedName() => "gameAIGetIsSpeaking";
}