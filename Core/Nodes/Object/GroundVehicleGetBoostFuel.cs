/*
 * Filename: GroundVehicleGetBoostFuel.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the amount of boost fuel held by a vehicle
 * Types: 
 * 
 * INPUTS: 
 * Target (Ground Vehicle)
 *
 * OUTPUTS: 
 * Boost amount (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("76d46244-7b8e-43de-bd8c-55375411ffe1")]
public class GroundVehicleGetBoostFuel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Get Boost Fuel";
    public string GetVariableQualifiedName() => "groundVehicleGetBoostFuel";
}