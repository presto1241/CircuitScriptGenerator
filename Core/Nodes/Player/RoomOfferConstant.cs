/*
 * Filename: RoomOfferConstant.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description:  Constant chip that can be configured to expose a Room Offer to circuits
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Room Offer)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("1d129345-7897-4a9c-b364-6aaf35333164")]
public class RoomOfferConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Offer Constant";
    public string GetVariableQualifiedName() => "roomOfferConstant";
}