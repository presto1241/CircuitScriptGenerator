/*
 * Filename: InventoryItemGetImage.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the image of the given inventory item
 * Types: 
 * 
 * INPUTS: 
 * Inventory Item (Inventory Item)
 *
 * OUTPUTS: 
 * Image (RecNet Image)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("aaa5f89c-abb4-42ef-a300-6a3acf528ea4")]
public class InventoryItemGetImage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inventory Item Get Image";
    public string GetVariableQualifiedName() => "inventoryItemGetImage";
}