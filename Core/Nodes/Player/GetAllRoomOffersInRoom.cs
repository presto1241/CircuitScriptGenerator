/*
 * Filename: GetAllRoomOffersInRoom.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a list with all the room offers in this room.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Room Offers (List<Room Offer>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("84fac8fc-6116-43d3-a45f-c0567b62e80a")]
public class GetAllRoomOffersInRoom : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get All Room Offers In Room";
    public string GetVariableQualifiedName() => "getAllRoomOffersInRoom";
}