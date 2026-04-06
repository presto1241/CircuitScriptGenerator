/*
 * Filename: GetRoomOfferDynamicPriceValues.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets dynamic price values from a room offer
 * Types: 
 * 
 * INPUTS: 
 * Room Offer (Room Offer)
 *
 * OUTPUTS: 
 * Baseline Price (int)
 * Minimum Dynamic Price (int)
 * Maximum Dynamic Price (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("5905954e-0301-4fd9-a8a7-078047d0f140")]
public class GetRoomOfferDynamicPriceValues : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Room Offer Dynamic Price Values";
    public string GetVariableQualifiedName() => "getRoomOfferDynamicPriceValues";
}