/*
 * Filename: GameAIRequestSetInstructions.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the instructions for the Game AI without resetting the conversation history
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Value (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Set (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("8e7fa483-c82c-44a1-9bcd-ef80239d270d")]
public class GameAIRequestSetInstructions : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Request Set Instructions";
    public string GetVariableQualifiedName() => "gameAIRequestSetInstructions";
}