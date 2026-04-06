/*
 * Filename: PlayerGetIsCustomFootstepAudioActive.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether custom footstep audio is active for the given player. If true, the internal foostep audio will be disabled and footstep sounds will instead be played via circuits in the default player definition board. If false, the internal footstep audio systems will run.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Active (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d5a7f0e5-b0ab-4b6d-82d2-cdecade30009")]
public class PlayerGetIsCustomFootstepAudioActive : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Custom Footstep Audio Active";
    public string GetVariableQualifiedName() => "playerGetIsCustomFootstepAudioActive";
}