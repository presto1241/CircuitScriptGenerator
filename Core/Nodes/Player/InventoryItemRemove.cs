/*
 * Filename: InventoryItemRemove.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Remove an inventory item from the given player.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Inventory Item (Inventory Item)
 * Player (Player)
 * Quantity (int)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * Success (bool)
 * Total Count (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("736abfd6-5a44-4c74-9fc2-663adf6cbbdf")]
public class InventoryItemRemove : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inventory Item Remove";
    public string GetVariableQualifiedName() => "inventoryItemRemove";
}