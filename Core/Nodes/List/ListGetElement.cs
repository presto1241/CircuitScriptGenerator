/*
 * Filename: ListGetElement.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a specified element from the input list. The "Index" is the location of the element in the list. The first element in the list is at index 0, the second element is at index 1.
 * Types: any
 * 
 * INPUTS: 
 * List (List<T>)
 * Index (int)
 *
 * OUTPUTS: 
 * Value (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("e8c5082f-0a75-4025-9679-293bc8d72989")]
public class ListGetElement : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Get Element";
    public string GetVariableQualifiedName() => "listGetElement";
}