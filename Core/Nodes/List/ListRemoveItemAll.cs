/*
 * Filename: ListRemoveItemAll.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Removes all instances of item from list.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (List<T>)
 * Item (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("370f1016-69e0-4265-a4a2-7841067f1fa7")]
public class ListRemoveItemAll : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Remove Item (All)";
    public string GetVariableQualifiedName() => "listRemoveItemAll";
}