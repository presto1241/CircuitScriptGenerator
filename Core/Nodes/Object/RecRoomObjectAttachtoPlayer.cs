/*
 * Filename: RecRoomObjectAttachtoPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Attaches a Rec Room Object to a body part on the player with a position and rotation offset.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Object (Rec Room Object)
 * Player (Player)
 * Body Part (Body Part)
 * Position Offset (Vector3)
 * Rotation Offset (Quaternion)
 * Steal (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("fc2be761-1aa6-4d38-ab64-ed04da727c2b")]
public class RecRoomObjectAttachtoPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rec Room Object Attach to Player";
    public string GetVariableQualifiedName() => "recRoomObjectAttachtoPlayer";
}