/*
 * Filename: ListDistinct.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs a copy of the input list containing only its unique elements.
 * Types: any
 * 
 * INPUTS: 
 * List (List<T>)
 *
 * OUTPUTS: 
 * Result (List<T>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("7f15baa5-f804-4754-9cec-d1fe76a458b1")]
public class ListDistinct : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Distinct";
    public string GetVariableQualifiedName() => "listDistinct";
}