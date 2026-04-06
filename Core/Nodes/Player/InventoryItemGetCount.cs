/*
 * Filename: InventoryItemGetCount.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get the count of how many of the given inventory item the given player owns.
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Inventory Item (Inventory Item)
 * Player (Player)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * Total Count (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("2e1cb4fa-a341-40fe-acba-e8621f7c69ca")]
public class InventoryItemGetCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inventory Item Get Count";
    public string GetVariableQualifiedName() => "inventoryItemGetCount";
}