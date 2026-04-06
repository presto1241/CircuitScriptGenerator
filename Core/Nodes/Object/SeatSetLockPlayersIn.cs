/*
 * Filename: SeatSetLockPlayersIn.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Prevents a Seated player from unseating themselves on a target Seat. Use circuits to unseat or unlock.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Seat)
 * Lock Players In (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("af071963-a0df-422e-8372-e561336921db")]
public class SeatSetLockPlayersIn : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Seat Set Lock Players In";
    public string GetVariableQualifiedName() => "seatSetLockPlayersIn";
}