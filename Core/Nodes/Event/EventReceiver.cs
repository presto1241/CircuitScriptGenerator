/*
 * Filename: EventReceiver.cs
 * Category: Event
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Events are the entry points for all circuit graphs. Events are execution hooks for things like a player loading into the room, or knowing when a Button is pressed. After creating this chip, make sure to use the configure tool to choose the event you want to listen for. You can use the Event Defintion chip to create your own events to add to this list and use with the Event Sender chip.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Event;

[Node("8b533ccb-643a-491d-982c-94417ce99954")]
public class EventReceiver : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Event Receiver";
    public string GetVariableQualifiedName() => "eventReceiver";
}