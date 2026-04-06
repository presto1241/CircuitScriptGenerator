/*
 * Filename: StudioEventSenderStringInt.cs
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
 * Value0 (string)
 * Value1 (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.RecRoomStudio;

[Node("dabac52b-26ef-422d-bded-e9234449b989")]
public class StudioEventSenderStringInt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Event Sender - String, Int";
    public string GetVariableQualifiedName() => "studioEventSenderStringInt";
}