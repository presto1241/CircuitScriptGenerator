/*
 * Filename: GroundVehicleAddBoostFuel.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Adds the given amount to the vehicle's boost fuel counter
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 * Boost amount (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("dc78ca9e-29c4-4cba-a6cb-3ea87ffbe780")]
public class GroundVehicleAddBoostFuel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Add Boost Fuel";
    public string GetVariableQualifiedName() => "groundVehicleAddBoostFuel";
}