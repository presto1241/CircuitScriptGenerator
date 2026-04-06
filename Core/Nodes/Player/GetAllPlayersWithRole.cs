/*
 * Filename: GetAllPlayersWithRole.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outpus List<Player> that continues every player with the specified role.
 * Types: 
 * 
 * INPUTS: 
 * Role Name (string)
 *
 * OUTPUTS: 
 * Players (List<Player>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("1c0a6bd4-bcac-40a9-8bae-fceff7ff7cff")]
public class GetAllPlayersWithRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get All Players With Role";
    public string GetVariableQualifiedName() => "getAllPlayersWithRole";
}