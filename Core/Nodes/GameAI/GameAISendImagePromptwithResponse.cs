/*
 * Filename: GameAISendImagePromptwithResponse.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a system prompt with an image to the Game AI and waits for a text response.

This is a special type of prompt that is not stored in the AI’s context and does not play audio.

If you want the response to be remembered, use the Response output along with a system prompt.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Prompt (string)
 * Image (Texture)
 * Use Context (string)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response (exec)
 * Success (bool)
 * Response (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("1d93fd4c-b801-474b-b36a-f713f833a813")]
public class GameAISendImagePromptwithResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Send Image Prompt with Response";
    public string GetVariableQualifiedName() => "gameAISendImagePromptwithResponse";
}