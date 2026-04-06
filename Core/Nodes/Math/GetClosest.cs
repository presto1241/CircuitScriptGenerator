/*
 * Filename: GetClosest.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Finds the element in Targets that is closest in space to Origin, and returns it, its index in the list, and its distance to Origin.
 * Types: (Rec Room Object | Player | Vector3)
 * 
 * INPUTS: 
 * Origin (T1)
 * Targets (List<T2>)
 *
 * OUTPUTS: 
 * Closest (T2)
 * Closest Index (int)
 * Distance (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("49fa5928-1af5-49e3-96d0-5ae67e6d81c9")]
public class GetClosest : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Closest";
    public string GetVariableQualifiedName() => "getClosest";
}