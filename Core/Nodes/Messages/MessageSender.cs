/*
 * Filename: MessageSender.cs
 * Category: Messages
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sends a message to `Message Receiver` chips configured with the matching message name.

If this Sender does not supply a message parameter that a Receiver reads, that Receiver will get the default value for that parameter.

Senders can be configured to send to all Receivers in the room or to only a specific object hierarchy's Receivers. Senders can also be configured to choose which players receive their message.
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

namespace CircuitScriptGenerator.Core.Nodes.Messages;

[Node("39c900d3-eb9a-44f3-9f36-9ac209ffa82a")]
public class MessageSender : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Message Sender";
    public string GetVariableQualifiedName() => "messageSender";
}