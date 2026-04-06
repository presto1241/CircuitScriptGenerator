/*
 * Filename: LocomotionRequestWallClimbStart.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Requests for the local player to start wall climbing. Will only start a wall climb if executed by the Locomotion Wall Climb Ready event.

The player will be accelerated to Max Speed over Acceleration Duration seconds. If Acceleration Duration is 0, Max Speed will be reached instantly.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Max Speed (float)
 * Acceleration Duration (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("11d7b8df-d04f-4d5d-b4ec-604d8f363ab6")]
public class LocomotionRequestWallClimbStart : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Wall Climb Start";
    public string GetVariableQualifiedName() => "locomotionRequestWallClimbStart";
}