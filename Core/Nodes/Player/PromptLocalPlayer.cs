/*
 * Filename: PromptLocalPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a watch notification to a player. The player which it sends a notification to depends on who's machine fires the exec pin. Once this watch notification is opened, the player can type responses into the text box and send back responses. You can define the prompt title and the prompt itself via inputs, and can also receive the player’s response via an output pin.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Prompt Title (string)
 * Prompt (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Complete (exec)
 * Response (string)
 * Failed (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("46e6b40e-2416-4078-b7dc-a0ecc2c2aa20")]
public class PromptLocalPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Prompt Local Player";
    public string GetVariableQualifiedName() => "promptLocalPlayer";
}