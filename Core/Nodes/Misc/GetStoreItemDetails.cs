/*
 * Filename: GetStoreItemDetails.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Store Item (Store Item)
 *
 * OUTPUTS: 
 * Item Name (string)
 * Item Description (string)
 * Item Image (RecNet Image)
 * Item Price (int)
 * Is In Set (bool)
 * Set Name (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("861ec611-2c0f-471c-9cff-c8a72e7c1c98")]
public class GetStoreItemDetails : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Store Item Details";
    public string GetVariableQualifiedName() => "getStoreItemDetails";
}