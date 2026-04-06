/*
 * Filename: ObjectiveMarkerGetLabelEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Label Is Enabled returns whether or not the target Objective Marker’s text label is visible for the local player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Enabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("79b28dea-36c7-4c4d-b523-7461667851a2")]
public class ObjectiveMarkerGetLabelEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Label Enabled";
    public string GetVariableQualifiedName() => "objectiveMarkerGetLabelEnabled";
}