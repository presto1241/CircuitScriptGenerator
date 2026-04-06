/*
 * Filename: ShowPlayerProfile.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Shows the profile page of a given account in a player's watch
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player Account (Player Account)
 * Player (Player)
 *
 * OUTPUTS: 
 * Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("66ec1823-1d63-4f62-8c1e-371d4d1a34dd")]
public class ShowPlayerProfile : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Player Profile";
    public string GetVariableQualifiedName() => "showPlayerProfile";
}