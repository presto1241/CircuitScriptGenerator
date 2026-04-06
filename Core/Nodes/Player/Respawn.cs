/*
 * Filename: Respawn.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the position and rotation of the target player or object. Players will rotate about the vertical axis only. Will fail in the following cases: If the target object is currently held, selected/frozen by the maker pen, or is the child of a gizmo. Will also fail on players that are seated.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (T)
 * Position (Vector3)
 * Rotation (U)
 * Spawn Radius (float)
 * Clear Velocity (bool)
 * Use Rez Effects (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("950368dc-fbdd-4627-a0e3-157fd2955276")]
public class Respawn : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Respawn";
    public string GetVariableQualifiedName() => "respawn";
}