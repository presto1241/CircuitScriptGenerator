/*
 * Filename: ObjectiveMarkerGetFadeThreshold.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Fade Threshold returns the current fade threshold of the target Objective Marker for the local player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Fade Threshold (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("6fe14d02-0382-4f94-a6ef-f3d414015e95")]
public class ObjectiveMarkerGetFadeThreshold : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Fade Threshold";
    public string GetVariableQualifiedName() => "objectiveMarkerGetFadeThreshold";
}