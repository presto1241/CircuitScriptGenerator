/*
 * Filename: RequestStopAvatarLocomotionAnimation.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Stops the current requested animation if any and returns the player to the default standing state.
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

[Node("3177b5c2-b894-4e92-8696-f77e7b841c4a")]
public class RequestStopAvatarLocomotionAnimation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Request Stop Avatar Locomotion Animation";
    public string GetVariableQualifiedName() => "requestStopAvatarLocomotionAnimation";
}