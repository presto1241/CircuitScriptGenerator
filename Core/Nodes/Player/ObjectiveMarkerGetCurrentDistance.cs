/*
 * Filename: ObjectiveMarkerGetCurrentDistance.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Current Distance returns the current distance of the local player from the target Objective Marker, regardless of whether the distance indicator is enabled.
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Distance (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a4ab4e75-1031-4f68-9631-ef31f131c708")]
public class ObjectiveMarkerGetCurrentDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Current Distance";
    public string GetVariableQualifiedName() => "objectiveMarkerGetCurrentDistance";
}