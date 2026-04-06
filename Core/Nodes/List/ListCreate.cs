/*
 * Filename: ListCreate.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a list from input values. Add more inputs by using the configure tool on the node and press "Add Input". All items in a list must be of the same type.
 * Types: any
 * 
 * INPUTS: 
 * Item (T)
 *
 * OUTPUTS: 
 * List (List<T>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("542d3256-0d51-4c33-a2a1-fbc44b7e1f07")]
public class ListCreate : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Create";
    public string GetVariableQualifiedName() => "listCreate";
}