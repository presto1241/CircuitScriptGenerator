/*
 * Filename: GroundVehicleSetDrivingEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether the vehicle can be driven by the player in the driver's seat. If true, the dirver can drive the vehicle. If false, the driver's seat can still be sat in, but you cannot drive the vehicle.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6c7a86cc-2145-404c-b029-31d22f9811e7")]
public class GroundVehicleSetDrivingEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Set Driving Enabled";
    public string GetVariableQualifiedName() => "groundVehicleSetDrivingEnabled";
}