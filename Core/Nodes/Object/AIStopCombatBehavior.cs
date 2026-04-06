/*
 * Filename: AIStopCombatBehavior.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Tells the input AI to stop its C# defined combat behavior.
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

[Node("6e244bf2-cf71-4baa-912d-3e61c7fcd1be")]
public class AIStopCombatBehavior : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Stop Combat Behavior";
    public string GetVariableQualifiedName() => "aIStopCombatBehavior";
}