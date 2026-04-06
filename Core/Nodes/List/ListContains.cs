/*
 * Filename: ListContains.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the target list contains the input value.
 * Types: any
 * 
 * INPUTS: 
 * Target (List<T>)
 * Item (T)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("73f261e2-d65d-4607-858d-3f4c37c76963")]
public class ListContains : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Contains";
    public string GetVariableQualifiedName() => "listContains";
}