/*
 * Filename: RoomBackgroundObjectsReset.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resets the room's shared background objects state to the room default.
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

[Node("71b85a8d-cda7-481f-a795-156bd8318d95")]
public class RoomBackgroundObjectsReset : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Background Objects Reset";
    public string GetVariableQualifiedName() => "roomBackgroundObjectsReset";
}