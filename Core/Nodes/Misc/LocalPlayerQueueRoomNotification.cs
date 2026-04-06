/*
 * Filename: LocalPlayerQueueRoomNotification.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Hours till sent (float)
 * Message (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * On Notification Scheduled (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("bd276c58-08e5-4d0f-b836-f8d89c16c34f")]
public class LocalPlayerQueueRoomNotification : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Queue Room Notification";
    public string GetVariableQualifiedName() => "localPlayerQueueRoomNotification";
}