/*
 * Filename: LocalPlayerSetRoomOfferPriceOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the overriden dynamic price of a room offer. Will clamp the price if it falls outside of the minimum/maximum range.
 * Types: 
 * 
 * INPUTS: 
 * Set Override (exec)
 * Room Offer (Room Offer)
 * Price (int)
 *
 * OUTPUTS: 
 * Set Override (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("efcce639-29a2-4472-8419-8d87bfea6f66")]
public class LocalPlayerSetRoomOfferPriceOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Room Offer Price Override";
    public string GetVariableQualifiedName() => "localPlayerSetRoomOfferPriceOverride";
}