/*
 * Filename: GroundVehicleUnseatPlayerFromSeat.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Unseats the player in the vehicle seat corresponding to the given index.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 * Seat index (int)
 *
 * OUTPUTS: 
 * Success (exec)
 * Failure (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4bb12ec4-780e-4186-a597-36bdc5c67b43")]
public class GroundVehicleUnseatPlayerFromSeat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Unseat Player From Seat";
    public string GetVariableQualifiedName() => "groundVehicleUnseatPlayerFromSeat";
}