/*
 * Filename: ListstringVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<string>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("94fb596f-6b3f-4981-bc2d-1bb693c45ae6")]
public class ListstringVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<string> Variable";
    public string GetVariableQualifiedName() => "liststringVariable";
}