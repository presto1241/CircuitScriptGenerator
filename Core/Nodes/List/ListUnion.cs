/*
 * Filename: ListUnion.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Combine lists together into one list and remove any duplicate elements.
 * Types: any
 * 
 * INPUTS: 
 * Value (List<T>)
 *
 * OUTPUTS: 
 * Output (List<T>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("304c312c-f3bd-460b-b54a-90ba343f2a7c")]
public class ListUnion : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Union";
    public string GetVariableQualifiedName() => "listUnion";
}