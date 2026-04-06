/*
 * Filename: ListboolVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<bool>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<bool>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("e0ef8c83-e5a6-4272-a102-07bfc0a40fd5")]
public class ListboolVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<bool> Variable";
    public string GetVariableQualifiedName() => "listboolVariable";
}