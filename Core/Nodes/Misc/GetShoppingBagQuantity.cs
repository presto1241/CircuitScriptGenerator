/*
 * Filename: GetShoppingBagQuantity.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get the number of items in the local player's shopping bag
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("c463362d-0309-4781-9ce1-43a7f36fef68")]
public class GetShoppingBagQuantity : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Shopping Bag Quantity";
    public string GetVariableQualifiedName() => "getShoppingBagQuantity";
}