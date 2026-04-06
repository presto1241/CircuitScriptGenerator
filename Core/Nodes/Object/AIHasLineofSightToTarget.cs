/*
 * Filename: AIHasLineofSightToTarget.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs if the input AI has line of sight to the input target.
 * Types: (AI | Combatant | Rec Room Object | Patrol Point | Player | Vector3)
 * 
 * INPUTS: 
 * AI (AI)
 * Target (T)
 *
 * OUTPUTS: 
 * Has LoS (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5858a52e-54fb-4bb2-80a0-ec5fce88b3ef")]
public class AIHasLineofSightToTarget : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Has Line of Sight To Target";
    public string GetVariableQualifiedName() => "aIHasLineofSightToTarget";
}