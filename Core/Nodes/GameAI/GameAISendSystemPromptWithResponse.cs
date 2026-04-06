/*
 * Filename: GameAISendSystemPromptWithResponse.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a system prompt to the Game AI and waits for a voice and text reply.

System prompts are issued from the AI’s perspective, not the user’s, and are intended as contextual observations or directives rather than conversational dialogue. Think of them as the AI’s thoughts.
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
 * System Conversation Item Id (string)
 * Response Conversation Item Id (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("4504de5c-3e13-46e5-9125-47e697c7bee5")]
public class GameAISendSystemPromptWithResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Send System Prompt With Response";
    public string GetVariableQualifiedName() => "gameAISendSystemPromptWithResponse";
}