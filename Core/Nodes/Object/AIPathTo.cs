/*
 * Filename: AIPathTo.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Commands the AI to path to the input target destination.
 * Types: (AI | Combatant | Rec Room Object | Patrol Point | Player | Vector3)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * AI (AI)
 * Target (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7b05df01-d4c8-490c-9442-55aa3b4975fa")]
public class AIPathTo : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Path To";
    public string GetVariableQualifiedName() => "aIPathTo";
}