/*
 * Filename: PlayerGetVoiceRolloffDistance.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the voice rolloff distance for the target player, as reckoned by the local player.

If the local player has set an override for the target player's voice rolloff distance, the "Has Local Override" bool returns true, and the overridden value is returned.

Otherwise, the synced value of that player's voice rolloff distance is returned, and the bool returns false.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Voice Rolloff Distance (m) (float)
 * Has Local Override (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7dd7ea91-2600-4002-804d-3a88d8b3b8a5")]
public class PlayerGetVoiceRolloffDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Voice Rolloff Distance";
    public string GetVariableQualifiedName() => "playerGetVoiceRolloffDistance";
}