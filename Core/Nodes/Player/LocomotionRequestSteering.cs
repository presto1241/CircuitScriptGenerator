/*
 * Filename: LocomotionRequestSteering.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Request that the local player is steered in the given direction, at the given speed.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Direction (Vector3)
 * Normalized Speed (float)
 * Max Steering Speed (float) - Max steering speed(m/s) regardless of locomotion state
 * Acceleration Time (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("0eead8ce-398b-4b0b-b16f-bad7be1bc11b")]
public class LocomotionRequestSteering : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Steering";
    public string GetVariableQualifiedName() => "locomotionRequestSteering";
}