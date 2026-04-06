/*
 * Filename: PlayerGetAllwithTag.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Searches the room for all players with the input tag and outputs them as a list.
 * Types: 
 * 
 * INPUTS: 
 * Tag (string)
 *
 * OUTPUTS: 
 * Players with Tag (List<Player>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("8286a047-19a2-4ad0-bdec-833f35adf4f2")]
public class PlayerGetAllwithTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get All with Tag";
    public string GetVariableQualifiedName() => "playerGetAllwithTag";
}