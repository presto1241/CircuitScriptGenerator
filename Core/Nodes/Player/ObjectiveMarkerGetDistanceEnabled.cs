/*
 * Filename: ObjectiveMarkerGetDistanceEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Distance Is Enabled returns whether or not the target Objective Marker’s distance indicator is visible for the local player.
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

[Node("6bca2a96-0f30-438e-89d8-aa77ffce2b1c")]
public class ObjectiveMarkerGetDistanceEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Distance Enabled";
    public string GetVariableQualifiedName() => "objectiveMarkerGetDistanceEnabled";
}