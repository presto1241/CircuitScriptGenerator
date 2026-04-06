/*
 * Filename: ListRecRoomObjectVariable.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Reads or writes a variable that stores a list of Rec Room Object references. This variable is unique in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Rec Room Object>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("536e376c-087d-4909-9412-3fcee5d6f52b")]
public class ListRecRoomObjectVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "List<Rec Room Object> Variable";
    public string GetVariableQualifiedName() => "listRecRoomObjectVariable";
}