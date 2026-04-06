/*
 * Filename: GameAIGetInstructions.cs
 * Category: Game AI
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Returns the current instructions for the AI
 * Types: 
 * 
 * INPUTS: 
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Value (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Game AI;

[Node("dae111ca-79a9-4b2e-9fb1-bd4727c84e52")]
public class GameAIGetInstructions : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Instructions";
    public string GetVariableQualifiedName() => "gameAIGetInstructions";
}