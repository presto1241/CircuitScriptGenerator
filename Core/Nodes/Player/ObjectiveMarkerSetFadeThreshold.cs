/*
 * Filename: ObjectiveMarkerSetFadeThreshold.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Set Fade Threshold sets the fade threshold of the target Objective Marker for the local player. This threshold is the distance (in meters) at which the marker has fully faded from sight as a player approaches it. For finer control over the fade duration, configure the Objective Marker constant.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Objective Marker)
 * Proximity (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("66e3efeb-c1df-45f2-ba9b-c261f938c80f")]
public class ObjectiveMarkerSetFadeThreshold : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Set Fade Threshold";
    public string GetVariableQualifiedName() => "objectiveMarkerSetFadeThreshold";
}