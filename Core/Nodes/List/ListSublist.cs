/*
 * Filename: ListSublist.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a sublist of the given list, at the given start index and with the given length.
 * Types: any
 * 
 * INPUTS: 
 * List (List<T>)
 * Start Index (int)
 * Length (int)
 *
 * OUTPUTS: 
 * Result (List<T>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("cdf23795-4789-4b9a-aa07-8d65b297da8c")]
public class ListSublist : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Sublist";
    public string GetVariableQualifiedName() => "listSublist";
}