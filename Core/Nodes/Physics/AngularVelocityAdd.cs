/*
 * Filename: AngularVelocityAdd.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Add angular velocity to an object. The Angular Velocity vector should lie along the axis of the rotation being added, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s. Once the new angular velocity has been computed, its speed will be capped by the Max Angular Speed.
 * Types: 
 * 
 * INPUTS: 
 * Add Velocity (exec)
 * Target (Rec Room Object)
 * Angular Velocity (Vector3)
 * Speed Multiplier (float)
 * Max Angular Speed (deg/s) (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("956ccd66-4406-42a3-b08c-78d3efdd5fec")]
public class AngularVelocityAdd : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Angular Velocity Add";
    public string GetVariableQualifiedName() => "angularVelocityAdd";
}