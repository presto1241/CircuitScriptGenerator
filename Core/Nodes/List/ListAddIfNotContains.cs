/*
 * Filename: ListAddIfNotContains.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Adds a new element to the end of the target list containing the input value, but only if the element isn't already in the list.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (List<T>)
 * Item (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("a107765d-643e-4b61-b144-7b8f4712f143")]
public class ListAddIfNotContains : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Add If Not Contains";
    public string GetVariableQualifiedName() => "listAddIfNotContains";
}