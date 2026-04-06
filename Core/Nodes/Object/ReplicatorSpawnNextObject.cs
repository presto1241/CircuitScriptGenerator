/*
 * Filename: ReplicatorSpawnNextObject.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Spawns a copy of the object assigned to the target replicator at the position and orientation specified. If “Assign to Player” is true, the resulting object will be assigned to the specified player such that no other players can interact with it, and the object will be automatically returned when that player leaves the room. 

When the object is spawned, On Spawn Complete will fire and pass through an object reference. If it fails, such as when the limit of objects has been hit, the object reference will be invalid and the Success bool will be false.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Replicator)
 * Position (Vector3)
 * Orientation (Quaternion)
 * Assign to Player (bool)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * On Spawn Complete (exec)
 * Object (Rec Room Object)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("fc467906-eb16-4d6f-9c51-e5bd0fbcd492")]
public class ReplicatorSpawnNextObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Replicator Spawn Next Object";
    public string GetVariableQualifiedName() => "replicatorSpawnNextObject";
}