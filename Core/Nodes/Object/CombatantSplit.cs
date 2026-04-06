/*
 * Filename: CombatantSplit.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Splits the input Combatant into Player and AI types. Use this off of Combatant outputs to directly access the Player or AI.
 * Types: 
 * 
 * INPUTS: 
 * Combatant (Combatant)
 *
 * OUTPUTS: 
 * Is Player (bool)
 * Player (Player)
 * AI (AI)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("81b08e44-0a1e-40da-b8a1-79f416691dcf")]
public class CombatantSplit : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Split";
    public string GetVariableQualifiedName() => "combatantSplit";
}