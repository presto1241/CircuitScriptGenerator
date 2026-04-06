/*
 * Filename: SetPositionDeprecated.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the position of the target player or object. Will fail in the following cases: If the target object is currently held, select/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (T)
 * Position (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Failed (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("ff1c2a15-4099-4aaa-afe3-c217b2fca15b")]
public class SetPositionDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Position (Deprecated)";
    public string GetVariableQualifiedName() => "setPositionDeprecated";
}