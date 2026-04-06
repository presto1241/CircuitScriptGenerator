/*
 * Filename: DistanceDeprecated.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the distance between the input objects.
 * Types: (AI | Combatant | Rec Room Object | Player | Vector3)
 * 
 * INPUTS: 
 * A (T1)
 * B (T2)
 *
 * OUTPUTS: 
 * Distance (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("182e1ae2-1183-4741-af6e-f307b788a857")]
public class DistanceDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Distance (Deprecated)";
    public string GetVariableQualifiedName() => "distanceDeprecated";
}