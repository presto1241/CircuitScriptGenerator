/*
 * Filename: boolVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("80955588-7f7a-4f7c-b46f-6d1e9057fba0")]
public class boolVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "bool Variable";
    public string GetVariableQualifiedName() => "boolVariable";
}