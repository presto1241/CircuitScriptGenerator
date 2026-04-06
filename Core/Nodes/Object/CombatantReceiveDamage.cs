/*
 * Filename: CombatantReceiveDamage.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Deals damage to the given target combatant with various parameters.
 * Types: (AI | Combatant | Player)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (T)
 * Damage (int)
 * Ignore Shield (bool)
 * Damage Source (Combatant) (U)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("67aca89c-f753-4f94-87df-1ce1d4fcb8b0")]
public class CombatantReceiveDamage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Receive Damage";
    public string GetVariableQualifiedName() => "combatantReceiveDamage";
}