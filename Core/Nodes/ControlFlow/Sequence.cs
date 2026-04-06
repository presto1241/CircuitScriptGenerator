/*
 * Filename: Sequence.cs
 * Category: Control Flow
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Executes all output ports in order.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * 1 (exec)
 * 2 (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ControlFlow;

[Node("9e2ac049-e68e-4689-a288-bef8a62da316")]
public class Sequence : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Sequence";
    public string GetVariableQualifiedName() => "sequence";
}