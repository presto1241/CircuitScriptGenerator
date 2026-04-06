/*
 * Filename: PlayerGetIsRoomMod.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the input Player is one of the current room's moderators.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("8f9b0921-a92b-4d01-a4d5-a8d2e6fc6ca0")]
public class PlayerGetIsRoomMod : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Room Mod";
    public string GetVariableQualifiedName() => "playerGetIsRoomMod";
}