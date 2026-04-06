/*
 * Filename: ListSort.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sorts the given list in place in either ascending or descending order.
 * Types: (float | int | string)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (List<T>)
 * Ascending (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("cc967d66-b201-464e-bddd-a7cf47124fec")]
public class ListSort : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Sort";
    public string GetVariableQualifiedName() => "listSort";
}