/*
 * Filename: SeatSetSeatedPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Seats an input player on a target Seat.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Seat)
 * Player (Player)
 *
 * OUTPUTS: 
 * Success (exec)
 * Fail (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("d652ebe5-1367-44ed-a352-1e5ab84c32b0")]
public class SeatSetSeatedPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Seat Set Seated Player";
    public string GetVariableQualifiedName() => "seatSetSeatedPlayer";
}