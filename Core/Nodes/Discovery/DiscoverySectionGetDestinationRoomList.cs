/*
 * Filename: DiscoverySectionGetDestinationRoomList.cs
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
 * List<Destination Room> (List<Destination Room>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Discovery;

[Node("09dcf839-60c5-406e-9728-c25837926b3f")]
public class DiscoverySectionGetDestinationRoomList : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Discovery Section Get Destination Room List";
    public string GetVariableQualifiedName() => "discoverySectionGetDestinationRoomList";
}