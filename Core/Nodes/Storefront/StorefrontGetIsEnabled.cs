/*
 * Filename: StorefrontGetIsEnabled.cs
 * Category: Storefront
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets whether the target UGC Storefront is Enabled
 * Types: 
 * 
 * INPUTS: 
 * Storefront (Storefront)
 *
 * OUTPUTS: 
 * Is Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Storefront;

[Node("cf8756e6-97b9-4785-b926-057bb8ad7afd")]
public class StorefrontGetIsEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Storefront Get Is Enabled";
    public string GetVariableQualifiedName() => "storefrontGetIsEnabled";
}