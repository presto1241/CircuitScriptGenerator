/*
 * Filename: For.cs
 * Category: Control Flow
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Iterates over the "From" pin (inclusive) to the "To" pin (exclusive).
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * From (Inclusive) (int)
 * To (Exclusive) (int)
 *
 * OUTPUTS: 
 * Loop (exec)
 * Index (int)
 * Done (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.ControlFlow;

[Node("8f945c22-988b-45d2-b7f2-409ba304fef4")]
public class For : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "For";
    public string GetVariableQualifiedName() => "for";
}