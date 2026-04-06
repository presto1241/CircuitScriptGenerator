/*
 * Filename: DiscoverySectionGetDisplayMetadata.cs
 * Category: Discovery
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Used to get the display metadata from a Discovery Section. Outputs a JSON-formatted string
 * Types: 
 * 
 * INPUTS: 
 * Discovery Section (Discovery Section)
 *
 * OUTPUTS: 
 * Display Metadata (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Discovery;

[Node("567e266e-1368-4dcc-96ba-a3bbcc547007")]
public class DiscoverySectionGetDisplayMetadata : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Discovery Section Get Display Metadata";
    public string GetVariableQualifiedName() => "discoverySectionGetDisplayMetadata";
}