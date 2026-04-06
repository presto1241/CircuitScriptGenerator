/*
 * Filename: ListSubtract.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Subtracts each element in the list by the next element.
 * Types: (float | int | Vector3)
 * 
 * INPUTS: 
 * Target (List<T>)
 *
 * OUTPUTS: 
 * Result (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("20f069cb-30e5-4df8-8e2f-d91f322a83dd")]
public class ListSubtract : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Subtract";
    public string GetVariableQualifiedName() => "listSubtract";
}