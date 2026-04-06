/*
 * Filename: ListRemoveItemFirst.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Removes the first instance of the item in the list, and returns the index where it was found (-1 if not present)
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (List<T>)
 * Item (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Index Removed (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("1657cd3d-6bc5-41d2-b70f-1854f9288ffa")]
public class ListRemoveItemFirst : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Remove Item (First)";
    public string GetVariableQualifiedName() => "listRemoveItemFirst";
}