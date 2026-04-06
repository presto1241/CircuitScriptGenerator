/*
 * Filename: SeatGetLockPlayersOut.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if the target Seat is set to lock players out.
 * Types: 
 * 
 * INPUTS: 
 * Target (Seat)
 *
 * OUTPUTS: 
 * Lock Out (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("e0214877-5f0a-46a2-8278-580f2fd293e0")]
public class SeatGetLockPlayersOut : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Seat Get Lock Players Out";
    public string GetVariableQualifiedName() => "seatGetLockPlayersOut";
}