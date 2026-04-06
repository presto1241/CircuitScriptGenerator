/*
 * Filename: ListMultiply.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Multiplies each element in the list by the next element.
 * Types: (float | int | Quaternion | Vector3)
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

[Node("585aebe5-5df3-423a-8bc4-66b4e2b8bc5b")]
public class ListMultiply : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Multiply";
    public string GetVariableQualifiedName() => "listMultiply";
}