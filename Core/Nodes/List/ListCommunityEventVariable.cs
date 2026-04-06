/*
 * Filename: ListCommunityEventVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable that stores a list of Community Events. This variable is unique in the current scope based on its name, and defaults to an empty list
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Community Event>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Community Event>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("2be6c6b9-39da-4efd-abfa-c531d91aa641")]
public class ListCommunityEventVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Community Event> Variable";
    public string GetVariableQualifiedName() => "listCommunityEventVariable";
}