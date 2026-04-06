/*
 * Filename: LocalPlayerOverridePlayerVoiceRolloff.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Override the voice rolloff distance of the target player as heard by the local player.

Other players' perception of the target player's voice rolloff will be unaffected.
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

[Node("bb4ff641-2267-45e0-9e07-fc480b04f478")]
public class LocalPlayerOverridePlayerVoiceRolloff : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Override Player Voice Rolloff";
    public string GetVariableQualifiedName() => "localPlayerOverridePlayerVoiceRolloff";
}