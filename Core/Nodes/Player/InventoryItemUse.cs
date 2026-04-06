/*
 * Filename: InventoryItemUse.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Uses the given inventory item.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Inventory Item (Inventory Item)
 *
 * OUTPUTS: 
 * Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("ead258fa-43c8-4504-b5e5-1dc5bf47c7c7")]
public class InventoryItemUse : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inventory Item Use";
    public string GetVariableQualifiedName() => "inventoryItemUse";
}