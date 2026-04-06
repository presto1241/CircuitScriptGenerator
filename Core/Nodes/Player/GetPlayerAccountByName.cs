/*
 * Filename: GetPlayerAccountByName.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a player account from a given username. Player does not need to be present in the room.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Account Name (string)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * Player Account (Player Account)
 * Account Exists (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f74ea812-d42a-4ec8-afd6-0365c98dbd6f")]
public class GetPlayerAccountByName : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player Account By Name";
    public string GetVariableQualifiedName() => "getPlayerAccountByName";
}