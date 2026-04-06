/*
 * Filename: StudioEventSenderInt.cs
 * Category: Rec Room Studio
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Fires a custom Unity Event defined in Rec Room Studio on a Studio Object
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Studio Object (Studio Object)
 * Event (string)
 * Value (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.RecRoomStudio;

[Node("1a29d0ac-0372-4a8a-84cd-9df9af8920a1")]
public class StudioEventSenderInt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Event Sender - Int";
    public string GetVariableQualifiedName() => "studioEventSenderInt";
}