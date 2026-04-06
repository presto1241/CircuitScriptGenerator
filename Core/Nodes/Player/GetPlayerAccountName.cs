/*
 * Filename: GetPlayerAccountName.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the player's Account name (e.g Coach) in a form of a string. To get a display name, use To String.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Player Name (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("6141ff64-412b-452f-beb0-f338eb6abfb5")]
public class GetPlayerAccountName : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player Account Name";
    public string GetVariableQualifiedName() => "getPlayerAccountName";
}