/*
 * Filename: LocalPlayerClearPlayerVoiceRolloffOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the local player's override of target player's voice rolloff distance.

The local player's reckoning of the target player's voice rolloff returns to being based on that player's voice rolloff distance property.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("1e33670b-5362-48d1-8f28-38df16e1b4c5")]
public class LocalPlayerClearPlayerVoiceRolloffOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Clear Player Voice Rolloff Override";
    public string GetVariableQualifiedName() => "localPlayerClearPlayerVoiceRolloffOverride";
}