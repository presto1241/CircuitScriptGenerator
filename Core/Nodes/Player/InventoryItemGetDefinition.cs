/*
 * Filename: InventoryItemGetDefinition.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the friendly name, description, image, and tag names of the given inventory item.
 * Types: 
 * 
 * INPUTS: 
 * Inventory Item (Inventory Item)
 *
 * OUTPUTS: 
 * Name (string)
 * Description (string)
 * SupportsUseAction (bool)
 * Image (RecNet Image)
 * Tags (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("93ad7158-81eb-453c-b3db-222b9630ae0e")]
public class InventoryItemGetDefinition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inventory Item Get Definition";
    public string GetVariableQualifiedName() => "inventoryItemGetDefinition";
}