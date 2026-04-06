/*
 * Filename: ListSortByKey.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a copy of the Key list in sorted order, and a copy of the Values list rearranged in the same order.
 * Types: (float | int | string)
 * 
 * INPUTS: 
 * Key (List<TKey>)
 * Values (List<TValue>)
 * Ascending (bool)
 *
 * OUTPUTS: 
 * Key Sorted (List<TKey>)
 * Values Sorted (List<TValue>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("0d69e5ad-e105-46ae-bc03-f53d5112c902")]
public class ListSortByKey : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Sort By Key";
    public string GetVariableQualifiedName() => "listSortByKey";
}