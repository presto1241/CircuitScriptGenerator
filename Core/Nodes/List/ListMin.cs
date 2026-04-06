/*
 * Filename: ListMin.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the lowest value in the target list.
 * Types: (float | int)
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

[Node("73e9cc79-66cc-4526-8ed7-87500e208c6b")]
public class ListMin : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Min";
    public string GetVariableQualifiedName() => "listMin";
}