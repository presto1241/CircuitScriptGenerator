/*
 * Filename: GameAISendUserPromptwithResponse.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a user prompt to the Game AI and waits for a voice and text reply.

User prompts are issued from the user's perspective and represent conversational input or commands directed at the AI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Prompt (string)
 * Should Wait For Audio (bool)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response Or Audio Finished (exec)
 * Success (bool)
 * Response (string)
 * User Conversation Item Id (string)
 * Response Conversation Item Id (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("2254dfa5-abc6-481f-92b2-31b3f252823f")]
public class GameAISendUserPromptwithResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Send User Prompt with Response";
    public string GetVariableQualifiedName() => "gameAISendUserPromptwithResponse";
}