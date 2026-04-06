/*
 * Filename: GroundVehicleGetDrivingEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the vehicle can be driven by the player in the driver's seat. If false, the driver's seat can still be sat in, but you cannot drive the vehicle.
 * Types: 
 * 
 * INPUTS: 
 * Target (Ground Vehicle)
 *
 * OUTPUTS: 
 * Driving Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f41ae49a-dbf3-4b4b-87dc-68614da242cc")]
public class GroundVehicleGetDrivingEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Get Driving Enabled";
    public string GetVariableQualifiedName() => "groundVehicleGetDrivingEnabled";
}