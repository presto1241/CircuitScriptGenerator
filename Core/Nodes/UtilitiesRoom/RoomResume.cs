/*
 * Filename: RoomResume.cs
 * Category: Utilities/Room
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resuming the room will resume all 'Update' events, resume all gizmos, and run the 'Room Resumed event.
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

[Node("1a8753dc-fade-4bce-8664-f797b7936d0f")]
public class RoomResume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Resume";
    public string GetVariableQualifiedName() => "roomResume";
}