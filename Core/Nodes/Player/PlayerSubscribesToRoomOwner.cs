/*
 * Filename: PlayerSubscribesToRoomOwner.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the input Player subscribes to one of the current room's owners.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Result (bool)
 * Seconds Until Enabled (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7e321d9b-4500-4917-9361-a32e1463401c")]
public class PlayerSubscribesToRoomOwner : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Subscribes To Room Owner";
    public string GetVariableQualifiedName() => "playerSubscribesToRoomOwner";
}