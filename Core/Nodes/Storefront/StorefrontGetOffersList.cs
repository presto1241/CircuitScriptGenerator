/*
 * Filename: StorefrontGetOffersList.cs
 * Category: Storefront
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns a list of offers used by the target UGC Storefront
 * Types: 
 * 
 * INPUTS: 
 * Storefront (Storefront)
 *
 * OUTPUTS: 
 * Offers List (List<Room Offer>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Storefront;

[Node("da53cfee-9e05-4ed0-adda-3086ddb3b9a9")]
public class StorefrontGetOffersList : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Storefront Get Offers List";
    public string GetVariableQualifiedName() => "storefrontGetOffersList";
}