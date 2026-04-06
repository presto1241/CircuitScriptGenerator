/*
 * Filename: GroundVehicleSetEngineTorqueMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets how much torque the vehicle's engine can apply. Torque determines how fast the vehicle can go and how well it can climb hills.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 * Torque multiplier (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("128116c8-591f-44bc-97cd-f787d660cfb5")]
public class GroundVehicleSetEngineTorqueMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Set Engine Torque Multiplier";
    public string GetVariableQualifiedName() => "groundVehicleSetEngineTorqueMultiplier";
}