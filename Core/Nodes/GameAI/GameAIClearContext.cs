/*
 * Filename: GameAIClearContext.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resets the AI’s memory, returning it to a fresh state with no prior context.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Cleared (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("ef5c702c-8dc3-4d56-9dfd-c6c46a0c0de1")]
public class GameAIClearContext : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Clear Context";
    public string GetVariableQualifiedName() => "gameAIClearContext";
}