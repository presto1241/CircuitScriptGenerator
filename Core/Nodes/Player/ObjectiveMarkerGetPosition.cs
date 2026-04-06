/*
 * Filename: ObjectiveMarkerGetPosition.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Get Position returns target Objective Marker’s current position for the local player as a vector
 * Types: 
 * 
 * INPUTS: 
 * Target (Objective Marker)
 *
 * OUTPUTS: 
 * Position (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("0a6b285e-cfb2-4112-88c3-ebe2ba3269a5")]
public class ObjectiveMarkerGetPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Get Position";
    public string GetVariableQualifiedName() => "objectiveMarkerGetPosition";
}