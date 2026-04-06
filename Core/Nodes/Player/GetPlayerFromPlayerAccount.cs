/*
 * Filename: GetPlayerFromPlayerAccount.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get a Player object from a Player Account. Only valid if that player is in the room.
 * Types: 
 * 
 * INPUTS: 
 * Player Account (Player Account)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("47719ea4-cbff-43cb-8484-a6f2c0996da5")]
public class GetPlayerFromPlayerAccount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player From Player Account";
    public string GetVariableQualifiedName() => "getPlayerFromPlayerAccount";
}