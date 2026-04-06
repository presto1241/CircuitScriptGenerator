/*
 * Filename: ObjectiveMarkerConstant.cs
 * Category: Constant
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Objective Marker Constant defines the default appearance of an Objective Marker. Use with Objective Marker Set Enabled, Objective Marker Set Position, and the other Objective Marker chips.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Objective Marker)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Constant;

[Node("9ffb119b-dadc-4e50-af19-9bfd335a34ef")]
public class ObjectiveMarkerConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Objective Marker Constant";
    public string GetVariableQualifiedName() => "objectiveMarkerConstant";
}