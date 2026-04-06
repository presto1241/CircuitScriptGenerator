/*
 * Filename: GameAIRequestResponse.cs
 * Category: Game AI
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Triggers a response from the Game AI without providing any prompt.

If Wait for Audio is enabled, the On Response or Audio actions will wait for the audio playback to complete before continuing.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Game AI)
 * Should Wait for Audio (bool)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Response or Audio Finished (exec)
 * Success (bool)
 * Response (string)
 * Conversation Item Id (string)
 * Error Message (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameAI;

[Node("3a615546-1239-4e0d-b2e4-7649c12b3d51")]
public class GameAIRequestResponse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Game AI Request Response";
    public string GetVariableQualifiedName() => "gameAIRequestResponse";
}