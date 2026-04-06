/*
 * Filename: GameAIRequestSetWackiness.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the wackiness for the Game AI without resetting the conversation history
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Value (float)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Set (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("bc476587-d1b5-4fdd-837f-681b5b292120")]
public class GameAIRequestSetWackiness : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Request Set Wackiness";
    public string GetVariableQualifiedName() => "gameAIRequestSetWackiness";
}