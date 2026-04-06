/*
 * Filename: RecRoomObjectVariable.cs
 * Category: Variable
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description:  Reads or writes a variable that stores a Rec Room Object reference. This variable is unique in the current scope based on the name.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Rec Room Object)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Variable;

[Node("7077d139-9876-495e-9756-58150fef9f3b")]
public class RecRoomObjectVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Variable";
    public string GetVariableQualifiedName() => "recRoomObjectVariable";
}