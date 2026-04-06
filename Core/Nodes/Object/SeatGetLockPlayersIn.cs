/*
 * Filename: SeatGetLockPlayersIn.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if the target Seat is set to lock players in.
 * Types: 
 * 
 * INPUTS: 
 * Target (Seat)
 *
 * OUTPUTS: 
 * Lock In (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("e46a3c37-7d53-4d4c-9484-48b0ac0694c4")]
public class SeatGetLockPlayersIn : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Seat Get Lock Players In";
    public string GetVariableQualifiedName() => "seatGetLockPlayersIn";
}