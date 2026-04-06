/*
 * Filename: ObjectiveMarkerGetEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Enabled returns whether or not the target Objective Marker is enabled for the local player.
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

[Node("67f3297e-f498-4e87-a170-5f42b59b0b3a")]
public class ObjectiveMarkerGetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Enabled";
    public string GetVariableQualifiedName() => "objectiveMarkerGetEnabled";
}