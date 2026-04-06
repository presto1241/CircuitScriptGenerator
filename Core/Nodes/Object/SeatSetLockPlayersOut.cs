/*
 * Filename: SeatSetLockPlayersOut.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Prevents players from sitting in a target seat.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Seat)
 * Lock Players Out (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("face947c-8ac1-4d8e-8318-e7ec98bf466d")]
public class SeatSetLockPlayersOut : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Seat Set Lock Players Out";
    public string GetVariableQualifiedName() => "seatSetLockPlayersOut";
}