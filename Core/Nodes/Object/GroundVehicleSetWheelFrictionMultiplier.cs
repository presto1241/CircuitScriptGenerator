/*
 * Filename: GroundVehicleSetWheelFrictionMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Wheel Friction affects how good the wheels are at gripping the ground - lower values decrease traction and make the wheels slip more and higher values can increase traction and make the wheels slip less. 1 is the default value for Wheel Friction.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 * Friction multiplier (float) - The lower this value is, the more the tires will slip instead of properly grabbing the ground
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d00aed86-97ac-4717-872e-ca6646ee266d")]
public class GroundVehicleSetWheelFrictionMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Set Wheel Friction Multiplier";
    public string GetVariableQualifiedName() => "groundVehicleSetWheelFrictionMultiplier";
}