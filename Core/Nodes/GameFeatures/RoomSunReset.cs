/*
 * Filename: RoomSunReset.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resets the room's shared sun state to the room default.
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

[Node("f62876ea-8c18-4566-ae4e-224d39fdcd89")]
public class RoomSunReset : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Sun Reset";
    public string GetVariableQualifiedName() => "roomSunReset";
}