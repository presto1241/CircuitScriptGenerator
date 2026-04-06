/*
 * Filename: ListGetCount.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the number of elements inside the input list.
 * Types: any
 * 
 * INPUTS: 
 * List (List<T>)
 *
 * OUTPUTS: 
 * Count (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("0493204d-9815-49a9-8c87-4dedf5ccf7e8")]
public class ListGetCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Get Count";
    public string GetVariableQualifiedName() => "listGetCount";
}