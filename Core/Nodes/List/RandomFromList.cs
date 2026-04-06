/*
 * Filename: RandomFromList.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a random element from the specified List.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * List (List<T>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Value (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("d253cef6-dd99-4357-b98a-e09a0c23bad7")]
public class RandomFromList : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Random From List";
    public string GetVariableQualifiedName() => "randomFromList";
}