/*
 * Filename: ListQuaternionVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Quaternion>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Quaternion>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("e8cfde19-33a4-4826-a032-4b9bd50aa171")]
public class ListQuaternionVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Quaternion> Variable";
    public string GetVariableQualifiedName() => "listQuaternionVariable";
}