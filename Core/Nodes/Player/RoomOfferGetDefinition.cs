/*
 * Filename: RoomOfferGetDefinition.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the friendly name, description, image, price, price unit, and inventory item list of the given room offer
 * Types: 
 * 
 * INPUTS: 
 * Room Offer (Room Offer)
 *
 * OUTPUTS: 
 * Name (string)
 * Description (string)
 * Image (RecNet Image)
 * Price (int)
 * Price Unit (Inventory Item)
 * Inventory Items (List<Inventory Item>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("caf164e9-b291-4dc7-99cb-f0ff147f9098")]
public class RoomOfferGetDefinition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Offer Get Definition";
    public string GetVariableQualifiedName() => "roomOfferGetDefinition";
}