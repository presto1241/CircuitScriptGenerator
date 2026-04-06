/*
 * Filename: InventoryItemConstant.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Can be configured to provide a reference to one of this room's Inventory Items
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Inventory Item)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("04cc0f81-b7d4-4469-aaa4-428b6e0c1f02")]
public class InventoryItemConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inventory Item Constant";
    public string GetVariableQualifiedName() => "inventoryItemConstant";
}