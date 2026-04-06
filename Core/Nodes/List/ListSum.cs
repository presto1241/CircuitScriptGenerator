/*
 * Filename: ListSum.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Adds each element in the list by the next element.
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

[Node("d080c9af-402f-4eb9-91d6-9eee945bf734")]
public class ListSum : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Sum";
    public string GetVariableQualifiedName() => "listSum";
}