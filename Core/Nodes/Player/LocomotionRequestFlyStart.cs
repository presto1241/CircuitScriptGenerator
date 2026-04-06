/*
 * Filename: LocomotionRequestFlyStart.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used by custom locomotion to request that the local player start flying. Can fail if flying is disabled or if the player is in a state that does not allow transitioning to flying. If successful, the player will be flying next frame.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("e555862a-7066-4fc3-ba3b-aa19ca7544e1")]
public class LocomotionRequestFlyStart : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Fly Start";
    public string GetVariableQualifiedName() => "locomotionRequestFlyStart";
}