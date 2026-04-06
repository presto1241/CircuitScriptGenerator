/*
 * Filename: GetCurrencyBalance.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the local players balance of one room currency. Configure this chip to selecht which currency to use.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Get Balance Complete (exec)
 * Success (bool)
 * Total Balance (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a4b0c860-e7f0-4abf-ad7c-9be1805c3d01")]
public class GetCurrencyBalance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Currency Balance";
    public string GetVariableQualifiedName() => "getCurrencyBalance";
}