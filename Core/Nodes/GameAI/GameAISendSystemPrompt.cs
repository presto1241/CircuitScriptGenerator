/*
 * Filename: GameAISendSystemPrompt.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a system prompt to the Game AI without expecting a reply.

System prompts are issued from the AI’s perspective, not the user’s, and are intended as contextual observations or directives rather than conversational dialogue. Think of them as the AI’s thoughts.
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

[Node("60e0626d-e55e-49e9-a8d6-860ccf6c9cfa")]
public class GameAISendSystemPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Send System Prompt";
    public string GetVariableQualifiedName() => "gameAISendSystemPrompt";
}