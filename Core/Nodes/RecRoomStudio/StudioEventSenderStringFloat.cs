/*
 * Filename: StudioEventSenderStringFloat.cs
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
 * Value1 (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.RecRoomStudio;

[Node("e394ced1-c594-4750-a4c1-6e861cfe57c0")]
public class StudioEventSenderStringFloat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Event Sender - String, Float";
    public string GetVariableQualifiedName() => "studioEventSenderStringFloat";
}