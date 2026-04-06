/*
 * Filename: CombatantVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Combatant)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Combatant)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("cfd8e246-8682-4707-a0ae-da55bacfbf72")]
public class CombatantVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Variable";
    public string GetVariableQualifiedName() => "combatantVariable";
}