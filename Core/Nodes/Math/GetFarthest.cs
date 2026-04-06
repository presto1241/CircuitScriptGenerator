/*
 * Filename: GetFarthest.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Finds the element in Targets that is farthest in space to Origin, and returns it, its index in the list, and its distance to Origin.
 * Types: (Rec Room Object | Player | Vector3)
 * 
 * INPUTS: 
 * Origin (T1)
 * Targets (List<T2>)
 *
 * OUTPUTS: 
 * Farthest (T2)
 * Farthest Index (int)
 * Distance (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("8e17bef6-59ea-4ff0-999a-a158800b22da")]
public class GetFarthest : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Farthest";
    public string GetVariableQualifiedName() => "getFarthest";
}