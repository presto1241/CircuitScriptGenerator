/*
 * Filename: ListAdd.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Adds a new element to the end of the target list containing the input value.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (List<T>)
 * Item (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("f716c3f3-0c7c-42a4-bf55-12b7e1cd9040")]
public class ListAdd : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List Add";
    public string GetVariableQualifiedName() => "listAdd";
}