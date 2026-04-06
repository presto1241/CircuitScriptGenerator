/*
 * Filename: ShowPlayerPortfolio.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Show portfolio page for a given player account on a player's Watch
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

[Node("4d62ed94-84f9-4ee7-b251-806c2b11bc70")]
public class ShowPlayerPortfolio : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Player Portfolio";
    public string GetVariableQualifiedName() => "showPlayerPortfolio";
}