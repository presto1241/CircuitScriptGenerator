/*
 * Filename: ListIntersect.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get a list of the elements that appear in every input list.
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

[Node("ddee857a-4be4-47a8-9dd7-782c02d5d1f6")]
public class ListIntersect : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Intersect";
    public string GetVariableQualifiedName() => "listIntersect";
}