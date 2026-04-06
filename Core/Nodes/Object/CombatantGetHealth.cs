/*
 * Filename: CombatantGetHealth.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the Health property of the input combatant.
 * Types: (AI | Combatant | Player)
 * 
 * INPUTS: 
 * Object (T)
 *
 * OUTPUTS: 
 * Health (int)
 * Shield (int)
 * Max Health (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3967a8ad-4237-4ae7-8cbf-850d8e24fe30")]
public class CombatantGetHealth : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Get Health";
    public string GetVariableQualifiedName() => "combatantGetHealth";
}