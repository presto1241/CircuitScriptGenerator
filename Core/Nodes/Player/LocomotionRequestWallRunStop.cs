/*
 * Filename: LocomotionRequestWallRunStop.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Request that the local player stop wall running. Not affected by CanWallRun directly. If you want that property to impact this request you should check it yourself.
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

[Node("cc6e247e-8bce-481c-b68e-e2449a5cb1fd")]
public class LocomotionRequestWallRunStop : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Wall Run Stop";
    public string GetVariableQualifiedName() => "locomotionRequestWallRunStop";
}