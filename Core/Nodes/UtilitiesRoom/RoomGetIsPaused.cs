/*
 * Filename: RoomGetIsPaused.cs
 * Category: Utilities/Room
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true if the room is currently paused.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Paused (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.UtilitiesRoom;

[Node("4bf1e2ec-d926-4a3d-9994-e94ea060f290")]
public class RoomGetIsPaused : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Get Is Paused";
    public string GetVariableQualifiedName() => "roomGetIsPaused";
}