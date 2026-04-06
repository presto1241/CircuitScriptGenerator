/*
 * Filename: CombatantSetMaxHealth.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the Max Health property of the input combatant.
 * Types: (AI | Combatant | Player)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (T)
 * Max Health (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("82f71bcc-5e83-4825-8306-6a2bb2a296dd")]
public class CombatantSetMaxHealth : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Set Max Health";
    public string GetVariableQualifiedName() => "combatantSetMaxHealth";
}