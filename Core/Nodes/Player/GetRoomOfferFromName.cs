/*
 * Filename: GetRoomOfferFromName.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the Room Offer that matches the provided name
 * Types: 
 * 
 * INPUTS: 
 * Name (string)
 *
 * OUTPUTS: 
 * Room Offer (Room Offer)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("77c8ded8-5555-4b3d-a441-2bbf1bdeafa7")]
public class GetRoomOfferFromName : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Room Offer From Name";
    public string GetVariableQualifiedName() => "getRoomOfferFromName";
}