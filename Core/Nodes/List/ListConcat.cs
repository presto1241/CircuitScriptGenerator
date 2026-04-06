/*
 * Filename: ListConcat.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Combine lists together into one list.
 * Types: any
 * 
 * INPUTS: 
 * List 1 (List<T>)
 * List 2 (List<T>)
 *
 * OUTPUTS: 
 * Result (List<T>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("0e2f21e0-bc71-423a-a983-72e27193ca8b")]
public class ListConcat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Concat";
    public string GetVariableQualifiedName() => "listConcat";
}