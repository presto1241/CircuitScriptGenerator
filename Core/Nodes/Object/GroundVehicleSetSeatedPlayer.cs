/*
 * Filename: GroundVehicleSetSeatedPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Seats the given player at the seat indicated by the given index. This will fail if the seat is occupied. Driver=0, Passenger=1, and back seats = 2 and 3.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Ground Vehicle)
 * Seat index (int)
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

[Node("50458d97-a7cf-45e3-892b-fb67c0fbe64b")]
public class GroundVehicleSetSeatedPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Ground Vehicle Set Seated Player";
    public string GetVariableQualifiedName() => "groundVehicleSetSeatedPlayer";
}