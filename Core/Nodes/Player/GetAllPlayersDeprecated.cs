/*
 * Filename: GetAllPlayersDeprecated.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs a list of all the players in the room currently.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Players (List<Player>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("09b0bf5b-95df-474b-b81a-4e8e2c78ed0a")]
public class GetAllPlayersDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get All Players (Deprecated)";
    public string GetVariableQualifiedName() => "getAllPlayersDeprecated";
}