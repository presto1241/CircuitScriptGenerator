/*
 * Filename: GetAnyPlayerwithRole.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a player with the role. Returns invalid player if no player has the role.
 * Types: 
 * 
 * INPUTS: 
 * Role (string)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a924cac0-0245-4846-862d-df4092c5e1c2")]
public class GetAnyPlayerwithRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Any Player with Role";
    public string GetVariableQualifiedName() => "getAnyPlayerwithRole";
}