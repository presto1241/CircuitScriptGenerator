/*
 * Filename: PlayerSetVoiceRolloffDistance.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the voice rolloff distance for a given player as heard by all other players.

Beyond this distance, the target player cannot be heard.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Voice Rolloff Distance (m) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7fd128dd-189b-4454-9824-5f482f8f5ce6")]
public class PlayerSetVoiceRolloffDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Voice Rolloff Distance";
    public string GetVariableQualifiedName() => "playerSetVoiceRolloffDistance";
}