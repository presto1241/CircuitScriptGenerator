/*
 * Filename: ToCombatant.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Covert a player or an AI value into a Combatant value.
 * Types: (AI | Player)
 * 
 * INPUTS: 
 * Player or AI (T)
 *
 * OUTPUTS: 
 * Combatant (Combatant)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("75a3a9c2-da17-4762-b87b-1735b44af659")]
public class ToCombatant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "To Combatant";
    public string GetVariableQualifiedName() => "toCombatant";
}