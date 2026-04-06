/*
 * Filename: PlayerGetIsRoomHost.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the input Player is one of the current room's hosts.
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

[Node("6f4324c5-4c7a-4243-97d0-58f027996534")]
public class PlayerGetIsRoomHost : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Room Host";
    public string GetVariableQualifiedName() => "playerGetIsRoomHost";
}