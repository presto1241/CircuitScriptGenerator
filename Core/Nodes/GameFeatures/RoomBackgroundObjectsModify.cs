/*
 * Filename: RoomBackgroundObjectsModify.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Changes the room's shared background objects state to the given configuration.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Background Objects (Background Objects)
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

[Node("79b90cab-14e3-4a90-8975-163506809c7e")]
public class RoomBackgroundObjectsModify : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Background Objects Modify";
    public string GetVariableQualifiedName() => "roomBackgroundObjectsModify";
}