/*
 * Filename: ListCreateWithSize.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Create a new list of the given size, where each element is set to the given value.
 * Types: any
 * 
 * INPUTS: 
 * Size (int)
 * Value (T)
 *
 * OUTPUTS: 
 * List (List<T>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("c63237a9-f6a5-45f0-80a9-ec0e08cefbe2")]
public class ListCreateWithSize : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Create With Size";
    public string GetVariableQualifiedName() => "listCreateWithSize";
}