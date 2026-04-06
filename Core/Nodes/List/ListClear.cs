/*
 * Filename: ListClear.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Removes all elements from a list
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * List (List<T>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("2314f2f2-979b-4d4a-ab02-fc3e7fdddad6")]
public class ListClear : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Clear";
    public string GetVariableQualifiedName() => "listClear";
}