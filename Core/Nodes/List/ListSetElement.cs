/*
 * Filename: ListSetElement.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets a value at a location in a list.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * List (List<T>)
 * Index (int)
 * Value (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("88daacc5-7652-4d3a-b505-ba256ce3fd9d")]
public class ListSetElement : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Set Element";
    public string GetVariableQualifiedName() => "listSetElement";
}