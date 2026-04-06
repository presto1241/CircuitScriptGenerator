/*
 * Filename: PlayerGetSeat.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the seat the target player is sitting in, if any. Returns an invalid seat if the player is not sitting in a seat.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Seat (Seat)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("47038300-2f6d-4876-bbb7-7c2e64fd9364")]
public class PlayerGetSeat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Seat";
    public string GetVariableQualifiedName() => "playerGetSeat";
}