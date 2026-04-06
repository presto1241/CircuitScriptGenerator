/*
 * Filename: ListintVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<int>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<int>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("fe2f9c12-d213-4234-a387-9d2ec1ad7fc1")]
public class ListintVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<int> Variable";
    public string GetVariableQualifiedName() => "listintVariable";
}