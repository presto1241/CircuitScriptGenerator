/*
 * Filename: GameAISendUserPrompt.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a user prompt to the Game AI without expecting a reply.

User prompts are issued from the user's perspective and represent conversational input or commands directed at the AI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Prompt (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Sent (exec)
 * Success (bool)
 * Conversation Item Id (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("4e10248f-c827-4283-bc16-5f6503783e3d")]
public class GameAISendUserPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Send User Prompt";
    public string GetVariableQualifiedName() => "gameAISendUserPrompt";
}