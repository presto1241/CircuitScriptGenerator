/*
 * Filename: ObjectiveMarkerSetColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Set Color sets target Objective Marker to the specified color for the local player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Objective Marker)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("9b701044-a1dc-4d74-830e-f0843b0c7056")]
public class ObjectiveMarkerSetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Set Color";
    public string GetVariableQualifiedName() => "objectiveMarkerSetColor";
}