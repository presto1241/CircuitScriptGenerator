/*
 * Filename: LocomotionRequestWallClimbStop.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Requests for the player to stop wall climbing, if they are currently wall climbing.
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

[Node("78368adb-7593-41b7-b18b-924fcad7d3a5")]
public class LocomotionRequestWallClimbStop : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Wall Climb Stop";
    public string GetVariableQualifiedName() => "locomotionRequestWallClimbStop";
}