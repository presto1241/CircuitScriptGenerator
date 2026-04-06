/*
 * Filename: HamTowerAISendUserPromptwithResponse.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a prompt to the Game AI for Ham Tower.

Not recommended for further use.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Request (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response (exec)
 * Response (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("391a66ec-8a6a-4c10-9d3e-550362c9389e")]
public class HamTowerAISendUserPromptwithResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ham Tower AI Send User Prompt with Response";
    public string GetVariableQualifiedName() => "hamTowerAISendUserPromptwithResponse";
}