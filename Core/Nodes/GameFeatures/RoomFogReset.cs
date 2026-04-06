/*
 * Filename: RoomFogReset.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resets the room's shared fog state to the room default.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Blend Time (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Blend Finished (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("8d447921-57aa-471c-9628-857071fc4a10")]
public class RoomFogReset : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Fog Reset";
    public string GetVariableQualifiedName() => "roomFogReset";
}