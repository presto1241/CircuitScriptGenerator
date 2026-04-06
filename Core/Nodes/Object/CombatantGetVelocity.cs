/*
 * Filename: CombatantGetVelocity.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the input combatant's current velocity and speed.
 * Types: (AI | Combatant | Player)
 * 
 * INPUTS: 
 * Combatant (T)
 *
 * OUTPUTS: 
 * Velocity (Vector3)
 * Speed (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b4eadbfa-cdbe-42e6-9481-5197de58e272")]
public class CombatantGetVelocity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Combatant Get Velocity";
    public string GetVariableQualifiedName() => "combatantGetVelocity";
}