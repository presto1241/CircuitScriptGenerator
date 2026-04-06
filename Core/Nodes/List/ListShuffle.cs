/*
 * Filename: ListShuffle.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Randomize the order of the values in the given list.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (List<T>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("26a97d16-34e6-48c7-83a3-6cf74c1e4985")]
public class ListShuffle : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Shuffle";
    public string GetVariableQualifiedName() => "listShuffle";
}