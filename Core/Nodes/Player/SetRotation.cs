/*
 * Filename: SetRotation.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (T)
 * Rotation (U)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("0a6f6078-8075-43c7-bbb2-32b63ae48e92")]
public class SetRotation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Rotation";
    public string GetVariableQualifiedName() => "setRotation";
}