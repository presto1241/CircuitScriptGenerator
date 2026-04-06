/*
 * Filename: stringVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("66b6ea20-9a00-4f80-9636-2cfb676b3965")]
public class stringVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "string Variable";
    public string GetVariableQualifiedName() => "stringVariable";
}