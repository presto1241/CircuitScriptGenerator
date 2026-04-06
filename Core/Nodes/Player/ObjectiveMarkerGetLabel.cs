/*
 * Filename: ObjectiveMarkerGetLabel.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Label returns the current text label of target Objective Marker for the local player as a string.
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Label (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("38569dac-4cbc-487c-9ca6-14e2cc0fbf05")]
public class ObjectiveMarkerGetLabel : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Label";
    public string GetVariableQualifiedName() => "objectiveMarkerGetLabel";
}