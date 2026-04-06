/*
 * Filename: GetAllInventoryItemsWithTag.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a List of Room Inventory Items that are tagged with the inputted tag.
 * Types: 
 * 
 * INPUTS: 
 * Tag (string)
 *
 * OUTPUTS: 
 * Inventory Items (List<Inventory Item>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("80ad6681-f1b1-448e-acc2-0736e4f6841d")]
public class GetAllInventoryItemsWithTag : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get All Inventory Items With Tag";
    public string GetVariableQualifiedName() => "getAllInventoryItemsWithTag";
}