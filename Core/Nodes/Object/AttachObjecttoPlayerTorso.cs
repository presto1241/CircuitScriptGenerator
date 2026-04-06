/*
 * Filename: AttachObjecttoPlayerTorso.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Attaches a Rec Room Object to the Torso of a player with a position and rotation offset 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Object To Attach (Rec Room Object)
 * Local Position (Vector3)
 * Local Rotation (Quaternion)
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

[Node("69eb07d2-5c02-4e23-8174-3d27de84edf7")]
public class AttachObjecttoPlayerTorso : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Attach Object to Player Torso";
    public string GetVariableQualifiedName() => "attachObjecttoPlayerTorso";
}