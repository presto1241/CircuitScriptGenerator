/*
 * Filename: GetInventoryItemFromName.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the Inventory Item that matches the provided friendly name
 * Types: 
 * 
 * INPUTS: 
 * Name (string)
 *
 * OUTPUTS: 
 * Inventory Item (Inventory Item)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f54582a2-90b1-4be4-a6c0-0d688b4f8067")]
public class GetInventoryItemFromName : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Inventory Item From Name";
    public string GetVariableQualifiedName() => "getInventoryItemFromName";
}