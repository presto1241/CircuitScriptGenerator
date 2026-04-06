/*
 * Filename: ForEach.cs
 * Category: Control Flow
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: Iterates over the input list. The loop exec fires for each element in the list. The Done exec fires once the end of the list has been reached.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Items (List<T>)
 *
 * OUTPUTS: 
 * Loop (exec)
 * Item (T)
 * Done (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Control Flow;

[Node("744e5311-6cc7-4130-962e-fe050a475d43")]
public class ForEach : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "For Each";
    public string GetVariableQualifiedName() => "forEach";
}