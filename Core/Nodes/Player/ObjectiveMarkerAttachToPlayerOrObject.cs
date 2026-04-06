/*
 * Filename: ObjectiveMarkerAttachToPlayerOrObject.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Attach To Player Or Object sets the position of target Objective Marker to the position of an object or a player, for the local player. Marker will track target object or player until position is set again. If a tracked player leaves the room, the marker will remain at the last tracked position.
 * Types: (Player | Rec Room Object)
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Objective Marker)
 * Player Or Object (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("bb7c408a-1fad-4612-a637-0b1a365baa1c")]
public class ObjectiveMarkerAttachToPlayerOrObject : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Attach To Player Or Object";
    public string GetVariableQualifiedName() => "objectiveMarkerAttachToPlayerOrObject";
}