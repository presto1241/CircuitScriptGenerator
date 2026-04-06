/*
 * Filename: DiscoverySectionGetStoreItemList.cs
 * Category: Discovery
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * Run (exec)
 * Discovery Section (Discovery Section)
 *
 * OUTPUTS: 
 * Run (exec)
 * Complete (exec)
 * List<T> (List<Store Item>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Discovery;

[Node("c8705f21-480b-49bb-827a-69d2375cf463")]
public class DiscoverySectionGetStoreItemList : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Discovery Section Get Store Item List";
    public string GetVariableQualifiedName() => "discoverySectionGetStoreItemList";
}