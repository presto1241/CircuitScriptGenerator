/*
 * Filename: RoomSkydomePlayerOverride.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Overrides the given player's room skydome state to the given configuration. This will take precedent over the room's shared skydome state.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Skydome (Skydome)
 * Player (Player)
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

[Node("f204d79b-fbd2-4b19-a4bf-b7eabe927bed")]
public class RoomSkydomePlayerOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Skydome Player Override";
    public string GetVariableQualifiedName() => "roomSkydomePlayerOverride";
}