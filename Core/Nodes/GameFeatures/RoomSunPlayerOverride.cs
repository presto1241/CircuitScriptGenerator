/*
 * Filename: RoomSunPlayerOverride.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Overrides the given player's room sun state to the given configuration. This will take precedent over the room's shared sun state.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Sun (Sun)
 * Sun Direction (Sun Direction)
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

[Node("6601dc45-6a5d-4a4d-986a-c3f265de9971")]
public class RoomSunPlayerOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Sun Player Override";
    public string GetVariableQualifiedName() => "roomSunPlayerOverride";
}