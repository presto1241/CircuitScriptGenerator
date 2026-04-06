/*
 * Filename: GroundVehicleUnseatPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Unseats the given player if they are sitting in the given vehicle.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 * Player (Player)
 *
 * OUTPUTS: 
 * Success (exec)
 * Failure (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("5815406b-a3f2-471e-88ec-dffc212293be")]
public class GroundVehicleUnseatPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Unseat Player";
    public string GetVariableQualifiedName() => "groundVehicleUnseatPlayer";
}