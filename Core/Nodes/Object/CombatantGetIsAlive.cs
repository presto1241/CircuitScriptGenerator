/*
 * Filename: CombatantGetIsAlive.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the input combatant is alive.
 * Types: (AI | Combatant | Player)
 * 
 * INPUTS: 
 * Object (T)
 *
 * OUTPUTS: 
 * Is Alive (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("2a12c389-c3c6-4484-8c63-21cdaf0fac6c")]
public class CombatantGetIsAlive : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Get Is Alive";
    public string GetVariableQualifiedName() => "combatantGetIsAlive";
}