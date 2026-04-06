/*
 * Filename: SeatUnseatPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Unseats a currently seated player on a target Seat.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Seat)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("70b682f5-5744-4a6a-beaa-a9dcd40066b6")]
public class SeatUnseatPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Seat Unseat Player";
    public string GetVariableQualifiedName() => "seatUnseatPlayer";
}