/*
 * Filename: Distance.cs
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

[Node("da92dbd5-5bbd-4afa-8eb1-2e88fff2380d")]
public class Distance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Distance";
    public string GetVariableQualifiedName() => "distance";
}