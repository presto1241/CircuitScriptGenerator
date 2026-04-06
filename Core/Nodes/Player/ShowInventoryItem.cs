/*
 * Filename: ShowInventoryItem.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Open room inventory to a specific inventory item (or default if unowned) for the given player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Inventory Item (Inventory Item)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("559c3d72-9ed5-40f4-977b-9802fe0daa50")]
public class ShowInventoryItem : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Show Inventory Item";
    public string GetVariableQualifiedName() => "showInventoryItem";
}