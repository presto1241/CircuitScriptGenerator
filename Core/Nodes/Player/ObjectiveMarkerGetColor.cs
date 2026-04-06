/*
 * Filename: ObjectiveMarkerGetColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Color returns the current color of target Objective Marker for the local player.
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7c9d1838-0b70-4a77-8cec-b67758a9095e")]
public class ObjectiveMarkerGetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Color";
    public string GetVariableQualifiedName() => "objectiveMarkerGetColor";
}