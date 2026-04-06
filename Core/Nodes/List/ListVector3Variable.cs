/*
 * Filename: ListVector3Variable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Vector3>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Vector3>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("35f84cfc-b10e-451e-832e-c6ad8d99685d")]
public class ListVector3Variable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Vector3> Variable";
    public string GetVariableQualifiedName() => "listVector3Variable";
}