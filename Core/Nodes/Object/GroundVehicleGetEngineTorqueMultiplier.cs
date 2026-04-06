/*
 * Filename: GroundVehicleGetEngineTorqueMultiplier.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns how much torque the vehicle's engine can apply. Torque determines how fast the vehicle can go and how well it can climb hills.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ground Vehicle)
 *
 * OUTPUTS: 
 * Torque Multiplier (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("390257d5-e382-4416-81f7-40562d5473d3")]
public class GroundVehicleGetEngineTorqueMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Get Engine Torque Multiplier";
    public string GetVariableQualifiedName() => "groundVehicleGetEngineTorqueMultiplier";
}