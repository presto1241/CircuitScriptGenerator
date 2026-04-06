/*
 * Filename: ListExcept.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get a list of all elements that appear in the first list but not in the other lists.
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

[Node("2333a01b-6b6f-43c0-b7c3-ea89df868a10")]
public class ListExcept : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Except";
    public string GetVariableQualifiedName() => "listExcept";
}