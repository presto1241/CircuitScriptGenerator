/*
 * Filename: ObjectiveMarkerSetPosition.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Set Position sets the position of target Objective Marker to a position vector for the local player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Objective Marker)
 * Position (Vector3)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("89599e52-1537-4696-91ea-fca1eb0ba26a")]
public class ObjectiveMarkerSetPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Set Position";
    public string GetVariableQualifiedName() => "objectiveMarkerSetPosition";
}