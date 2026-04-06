/*
 * Filename: RequestAvatarLocomotionAnimation.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Puts the player into a generic locomotion state and plays the configured
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

[Node("2c6b907b-d683-4b5d-afaf-d4ddfecb5ac6")]
public class RequestAvatarLocomotionAnimation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Request Avatar Locomotion Animation";
    public string GetVariableQualifiedName() => "requestAvatarLocomotionAnimation";
}