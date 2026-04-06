/*
 * Filename: PlayerGetIsRoomOwner.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the input Player is one of the current room's owners.
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

[Node("58c5cab7-ddf7-4de8-86c8-25f3d3c19d98")]
public class PlayerGetIsRoomOwner : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Room Owner";
    public string GetVariableQualifiedName() => "playerGetIsRoomOwner";
}