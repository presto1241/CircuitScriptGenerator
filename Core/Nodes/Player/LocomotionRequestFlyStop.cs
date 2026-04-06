/*
 * Filename: LocomotionRequestFlyStop.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used by custom locomotion to request that the local player stop flying. Can fail if the player is not flying. If successful, the player will not be flying next frame.
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

[Node("8670bf00-68b5-4d0c-abf3-a073407030ee")]
public class LocomotionRequestFlyStop : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Fly Stop";
    public string GetVariableQualifiedName() => "locomotionRequestFlyStop";
}