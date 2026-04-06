/*
 * Filename: LocalPlayerEnableInteractionwithTargetPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Enables the local player to interact with the provided player. To respond to interactions, configure a "Event Receiver" chip for the "Local Player... Interaction" events within a Player board. Hold duration is the number of seconds the player needs to hold the interact button to complete an interaction. If Hold duration is 0, the interaction will be a button press or tap on mobile platforms. Prompt is the string that will be displayed when a player interacts with the provided player.  Players will be interactive only for the players that ran this chip with them as the target player. Individual players may have different sets of players they can interact with. A player's interaction state is reset when the room is reset or reloaded. Enabling interactions with a player will make it so gestures do not work with them generally (e.g.: fistbumping, high-fiving, handshaking).
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Required Hold Duration (float)
 * Prompt (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("47455638-8ac9-4b9c-8201-20a12d43d513")]
public class LocalPlayerEnableInteractionwithTargetPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Enable Interaction with Target Player";
    public string GetVariableQualifiedName() => "localPlayerEnableInteractionwithTargetPlayer";
}