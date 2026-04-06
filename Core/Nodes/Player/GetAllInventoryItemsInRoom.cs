/*
 * Filename: GetAllInventoryItemsInRoom.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a list with all the inventory items in this room.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Inventory Items (List<Inventory Item>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("5ad0cd6b-90ad-4425-a43a-7ac7ec0d0141")]
public class GetAllInventoryItemsInRoom : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get All Inventory Items In Room";
    public string GetVariableQualifiedName() => "getAllInventoryItemsInRoom";
}