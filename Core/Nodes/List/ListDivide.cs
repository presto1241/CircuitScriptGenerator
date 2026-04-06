/*
 * Filename: ListDivide.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Divides each element in the list by the next element.
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

[Node("7e5af908-533d-4d42-b3c9-0159e2b5fd55")]
public class ListDivide : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Divide";
    public string GetVariableQualifiedName() => "listDivide";
}