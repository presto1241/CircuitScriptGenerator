/*
 * Filename: AwardCurrency.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Award some amount to the Player's balance of one room currency. Configure this chip to set the affected currency.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Player (Player)
 * Amount (int)
 *
 * OUTPUTS: 
 * Run (exec)
 * On Award Currency Complete (exec)
 * Success (bool)
 * Total Balance (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("03461631-734f-491b-ab86-6bdf66947556")]
public class AwardCurrency : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Award Currency";
    public string GetVariableQualifiedName() => "awardCurrency";
}