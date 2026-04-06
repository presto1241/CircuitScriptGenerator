/*
 * Filename: StorefrontSetOffersList.cs
 * Category: Storefront
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the list of offers shown in the target UGC Storefront
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Storefront (Storefront)
 * Offers List (List<Room Offer>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Storefront;

[Node("799fea09-63e3-495f-b516-014a7202dd0c")]
public class StorefrontSetOffersList : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Storefront Set Offers List";
    public string GetVariableQualifiedName() => "storefrontSetOffersList";
}