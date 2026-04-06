/*
 * Filename: CombatantGetGroundPosition.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the ground position of an input combatant.
 * Types: (AI | Combatant | Player)
 * 
 * INPUTS: 
 * Combatant (T)
 *
 * OUTPUTS: 
 * Ground Position (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c0ee02f4-bbab-40ea-88a0-7441d7e7094c")]
public class CombatantGetGroundPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Get Ground Position";
    public string GetVariableQualifiedName() => "combatantGetGroundPosition";
}