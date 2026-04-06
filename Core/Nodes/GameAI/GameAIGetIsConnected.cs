/*
 * Filename: GameAIGetIsConnected.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the Game AI is currently connected.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Finished (exec)
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("2ad892b9-ef08-4b83-bb2e-13b09e886397")]
public class GameAIGetIsConnected : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Get Is Connected";
    public string GetVariableQualifiedName() => "gameAIGetIsConnected";
}