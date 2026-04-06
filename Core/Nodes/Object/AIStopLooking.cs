/*
 * Filename: AIStopLooking.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Command the input AI to cancel its current Rotate and Look At commands. Call this before telling an AI to path after having it Rotate/Look At so it rotates properly while moving again.
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

[Node("f211a503-a237-41bc-875e-ae3ef62d745b")]
public class AIStopLooking : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AI Stop Looking";
    public string GetVariableQualifiedName() => "aIStopLooking";
}