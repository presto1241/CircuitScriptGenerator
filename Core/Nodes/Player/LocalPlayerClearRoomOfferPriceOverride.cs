/*
 * Filename: LocalPlayerClearRoomOfferPriceOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the overridden dynamic price of a room offer.
 * Types: 
 * 
 * INPUTS: 
 * Clear Override (exec)
 * Room Offer (Room Offer)
 *
 * OUTPUTS: 
 * Clear Override (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("962dbc08-918b-495d-baa8-ca54d1397d98")]
public class LocalPlayerClearRoomOfferPriceOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Clear Room Offer Price Override";
    public string GetVariableQualifiedName() => "localPlayerClearRoomOfferPriceOverride";
}