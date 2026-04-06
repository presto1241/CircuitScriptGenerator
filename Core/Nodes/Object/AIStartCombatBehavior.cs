/*
 * Filename: AIStartCombatBehavior.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: RRO Quest AI black box. This node tells the input AI to start their C# defined combat behavior. Note: this behavior varies per AI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * AI (AI)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b169c26e-3c2c-4058-bae7-dbbc3ee856a4")]
public class AIStartCombatBehavior : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Start Combat Behavior";
    public string GetVariableQualifiedName() => "aIStartCombatBehavior";
}