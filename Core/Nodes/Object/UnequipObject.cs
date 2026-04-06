/*
 * Filename: UnequipObject.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Attempts to unequip the specified object from whatever player is currently holding it or whatever player has it in one of their slots.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Object (Rec Room Object)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("df6cdb0c-24d7-447d-b29b-3979e51fb865")]
public class UnequipObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Unequip Object";
    public string GetVariableQualifiedName() => "unequipObject";
}