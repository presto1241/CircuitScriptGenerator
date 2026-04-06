/*
 * Filename: StudioEventSenderString.cs
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
 * Value (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.RecRoomStudio;

[Node("6bc4210c-dc16-4686-90bf-f95da3338b74")]
public class StudioEventSenderString : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Event Sender - String";
    public string GetVariableQualifiedName() => "studioEventSenderString";
}