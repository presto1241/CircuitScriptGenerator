/*
 * Filename: RoomFogModify.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Changes the room's shared fog state to the given configuration.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Fog (Fog)
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

[Node("2f9b5697-b309-474b-ad4d-361d17278f15")]
public class RoomFogModify : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Fog Modify";
    public string GetVariableQualifiedName() => "roomFogModify";
}