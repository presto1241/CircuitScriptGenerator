/*
 * Filename: PlayerPromptMultipleChoice.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a prompt to the specified player containing the prompt title and body, along with each of the answer choices on its own line. The player can choose a response and hit "ok," triggering the On Prompt Complete event. Since there is a delay between sending a prompt and receiving the response in which other responses may be received, the Player output can be used to disambiguate multiple responses. This prompt appears in the watch and can either bring the watch up automatically, or trigger a watch notification and show up when the player next opens their watch. To use a watch notification, disable the Immediate setting on the chip with the configure tool.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Prompt Title (string)
 * Prompt Body (string)
 * Answer Choices (List<string>)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Prompt Complete (exec)
 * Success (bool)
 * Receiving Player (Player)
 * Response (string)
 * Response Index (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d376a3c7-67c2-4607-a124-e2b93dc256d8")]
public class PlayerPromptMultipleChoice : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Prompt Multiple Choice";
    public string GetVariableQualifiedName() => "playerPromptMultipleChoice";
}