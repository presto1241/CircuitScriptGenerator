/*
 * Filename: GroundVehicleGetWheelFrictionMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Wheel friction affects how good the wheels are at gripping the ground. Lower values decrease traction and make the wheels slip more. Higher values can increase traction and make the wheels slip less. The default wheel friction is 1.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ground Vehicle)
 *
 * OUTPUTS: 
 * Friction Multiplier (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0fcc3c15-5ee0-4af9-a4de-94627fbba6ec")]
public class GroundVehicleGetWheelFrictionMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Get Wheel Friction Multiplier";
    public string GetVariableQualifiedName() => "groundVehicleGetWheelFrictionMultiplier";
}