/*
 * Filename: RoomBackgroundObjectsPlayerOverride.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Overrides the given player's room background objects state to the given configuration. This will take precedent over the room's shared background objects state.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Background Objects (Background Objects)
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

[Node("8ee487c2-9351-4f3b-9497-1e633d606f20")]
public class RoomBackgroundObjectsPlayerOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Room Background Objects Player Override";
    public string GetVariableQualifiedName() => "roomBackgroundObjectsPlayerOverride";
}