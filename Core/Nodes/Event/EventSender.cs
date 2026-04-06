/*
 * Filename: EventSender.cs
 * Category: Event
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Use the Event Sender to fire your custom events defined in Event Defintions. After creating this chip, make sure to use the configure tool to change the event that you want to fire. You can also change who you want to send the event to from the config menu.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Event;

[Node("96a8fe50-bc37-458b-bac9-582d45314779")]
public class EventSender : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Event Sender";
    public string GetVariableQualifiedName() => "eventSender";
}