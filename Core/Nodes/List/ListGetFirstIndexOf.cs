/*
 * Filename: ListGetFirstIndexOf.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns first index of the item in target list if that list contains it. Otherwise returns -1.
 * Types: any
 * 
 * INPUTS: 
 * Target (List<T>)
 * Item (T)
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("d8926108-6c7d-4c78-8fbd-baac2b210e03")]
public class ListGetFirstIndexOf : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Get First Index Of";
    public string GetVariableQualifiedName() => "listGetFirstIndexOf";
}