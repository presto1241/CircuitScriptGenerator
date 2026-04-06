/*
 * Filename: GetDiscoverySectionListFromSource.cs
 * Category: Discovery
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets a List of Discovery Sections from the Discovery service
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * SourceID (string)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * List<Discovery Section> (List<Discovery Section>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Discovery;

[Node("a238e1d9-f86c-423a-9ee1-16e46a0c4031")]
public class GetDiscoverySectionListFromSource : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Discovery Section List From Source";
    public string GetVariableQualifiedName() => "getDiscoverySectionListFromSource";
}