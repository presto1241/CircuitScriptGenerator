/*
 * Filename: RecNetImageVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (RecNet Image)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (RecNet Image)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("3a08bc14-bb99-4436-89e3-7131dcde08b0")]
public class RecNetImageVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "RecNet Image Variable";
    public string GetVariableQualifiedName() => "recNetImageVariable";
}