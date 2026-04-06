/*
 * Filename: AIGetTarget.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the current combat target of an inputted AI.
 * Types: 
 * 
 * INPUTS: 
 * AI (AI)
 *
 * OUTPUTS: 
 * Target (Combatant)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("1637b250-e497-4f4a-9d5e-64206488391c")]
public class AIGetTarget : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Get Target";
    public string GetVariableQualifiedName() => "aIGetTarget";
}