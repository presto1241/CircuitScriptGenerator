/*
 * Filename: ObjectiveMarkerSetEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Set Enabled enables or disables the target Objective Marker for the local player. Use with Objective Marker constant.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Objective Marker)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("8bc5eda2-94f1-4bae-879c-50f246155922")]
public class ObjectiveMarkerSetEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Set Enabled";
    public string GetVariableQualifiedName() => "objectiveMarkerSetEnabled";
}