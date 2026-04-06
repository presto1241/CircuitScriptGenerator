/*
 * Filename: RoomFogPlayerOverride.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Overrides the given player's room fog state to the given configuration. This will take precedent over the room's shared fog state.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Fog (Fog)
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

[Node("be4008ad-3f28-4a62-9b30-f479eb7c0542")]
public class RoomFogPlayerOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Fog Player Override";
    public string GetVariableQualifiedName() => "roomFogPlayerOverride";
}