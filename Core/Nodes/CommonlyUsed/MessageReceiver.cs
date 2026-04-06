/*
 * Filename: MessageReceiver.cs
 * Category: Commonly Used
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Receives a message from a `Message Sender` chip configured with the matching message name.

If a Sender does not supply a message parameter that this Receiver reads, this Receiver will get the default value for that parameter.
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

namespace CircuitScriptGenerator.Core.Nodes.CommonlyUsed;

[Node("99872f86-cfc9-49ff-9bc6-cfc85d233c27")]
public class MessageReceiver : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Message Receiver";
    public string GetVariableQualifiedName() => "messageReceiver";
}