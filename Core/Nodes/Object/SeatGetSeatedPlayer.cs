/*
 * Filename: SeatGetSeatedPlayer.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the currently seated player of a target Seat.
 * Types: 
 * 
 * INPUTS: 
 * Target (Seat)
 *
 * OUTPUTS: 
 * Player (Player)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("7fc01b3a-3f44-4cf1-ad2d-d5898fb35f4d")]
public class SeatGetSeatedPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Seat Get Seated Player";
    public string GetVariableQualifiedName() => "seatGetSeatedPlayer";
}