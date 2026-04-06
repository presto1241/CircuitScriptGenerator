/*
 * Filename: RoomSkydomeReset.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resets the room's shared skydome state to the room default.
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

[Node("79581488-2095-4ccd-a597-e3ed4d172105")]
public class RoomSkydomeReset : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Skydome Reset";
    public string GetVariableQualifiedName() => "roomSkydomeReset";
}