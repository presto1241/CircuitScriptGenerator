/*
 * Filename: GetPlayerRROCurrencyBalance.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the player's currency balance of the given RRO currency type
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Currency Type ID (int)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Complete (exec)
 * Success (bool)
 * Total Balance (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("d6c39a55-a747-457c-b817-27fa2042343b")]
public class GetPlayerRROCurrencyBalance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player RRO Currency Balance";
    public string GetVariableQualifiedName() => "getPlayerRROCurrencyBalance";
}