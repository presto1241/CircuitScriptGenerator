/*
 * Filename: ListGetAllIndicesOf.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns list of all indices of input item in target list if that list contains one or more instances of the item. Otherwise returns an empty list.
 * Types: any
 * 
 * INPUTS: 
 * Target (List<T>)
 * Item (T)
 *
 * OUTPUTS: 
 * Result (List<int>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("09066fc7-c88e-49f2-992c-5ed10f4ee682")]
public class ListGetAllIndicesOf : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Get All Indices Of";
    public string GetVariableQualifiedName() => "listGetAllIndicesOf";
}