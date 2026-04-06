/*
 * Filename: AngularVelocitySet.cs
 * Category: Physics
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the angular velocity of an object. The Angular Velocity vector should lie along the axis of rotation, with a magnitude that (once multiplied by the speed multiplier) represents the clockwise rotation speed in deg/s.
 * Types: 
 * 
 * INPUTS: 
 * Set Velocity (exec)
 * Target (Rec Room Object)
 * Angular Velocity (Vector3)
 * Speed Multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Physics;

[Node("85dbc1d1-759a-4d08-b129-bf9372188348")]
public class AngularVelocitySet : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Angular Velocity Set";
    public string GetVariableQualifiedName() => "angularVelocitySet";
}