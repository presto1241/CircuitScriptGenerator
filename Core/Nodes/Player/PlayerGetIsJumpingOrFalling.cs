/*
 * Filename: PlayerGetIsJumpingOrFalling.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the target player is jumping or falling - not contacting the ground, but also not flying.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Jumping Or Falling (bool)
 * Contact Surface (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a474eca1-e820-4249-a314-fbc0ae223a5f")]
public class PlayerGetIsJumpingOrFalling : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Jumping Or Falling";
    public string GetVariableQualifiedName() => "playerGetIsJumpingOrFalling";
}