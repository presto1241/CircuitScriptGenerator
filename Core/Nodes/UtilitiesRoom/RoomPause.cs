/*
 * Filename: RoomPause.cs
 * Category: Utilities/Room
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Pausing the room will stop all 'Update' events from running, stop all gizmos, and run the 'Room Paused' event.
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

namespace CircuitScriptGenerator.Core.Nodes.UtilitiesRoom;

[Node("c8fc837a-06f7-4323-a5a8-3cc8b77ac770")]
public class RoomPause : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Pause";
    public string GetVariableQualifiedName() => "roomPause";
}