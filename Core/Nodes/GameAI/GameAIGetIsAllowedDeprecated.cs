/*
 * Filename: GameAIGetIsAllowedDeprecated.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the Game AI is available to use in the room.
 * Types: 
 * 
 * INPUTS: 
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("592510bd-21f2-4bd5-86ae-db06fabb4358")]
public class GameAIGetIsAllowedDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Is Allowed (Deprecated)";
    public string GetVariableQualifiedName() => "gameAIGetIsAllowedDeprecated";
}