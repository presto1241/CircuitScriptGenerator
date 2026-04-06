/*
 * Filename: RoomSkydomeModify.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Changes the room's shared skydome state to the given configuration.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Skydome (Skydome)
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

[Node("fa6ebcdd-7551-4f05-91ca-101b2679cc0c")]
public class RoomSkydomeModify : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Skydome Modify";
    public string GetVariableQualifiedName() => "roomSkydomeModify";
}