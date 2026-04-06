/*
 * Filename: GroundVehicleApplyBoost.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Triggers a speed boost if the vehicle has enough boost fuel. You can set the amount of boost fuel required to boost in the vehicle's config menu if it is supported.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 *
 * OUTPUTS: 
 * Success (exec)
 * Failure (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("29dd429b-81e5-40c7-b3b6-8d03bcc1eec3")]
public class GroundVehicleApplyBoost : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Apply Boost";
    public string GetVariableQualifiedName() => "groundVehicleApplyBoost";
}