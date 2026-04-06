/*
 * Filename: ListfloatVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<float>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<float>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("9bcd36e6-c293-432a-8d90-f6391fe06c62")]
public class ListfloatVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<float> Variable";
    public string GetVariableQualifiedName() => "listfloatVariable";
}