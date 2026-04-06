/*
 * Filename: Vector3Variable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("fba2accf-44e2-412d-a204-ae3bd04f7dfa")]
public class Vector3Variable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Variable";
    public string GetVariableQualifiedName() => "vector3Variable";
}