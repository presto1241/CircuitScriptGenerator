/*
 * Filename: AABBContainsPoint.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Check whether a point is inside an Axis-Aligned Bounding Box (AABB)
 * Types: 
 * 
 * INPUTS: 
 * AABB Min (Vector3) - The minimum value of the x, y, and z coordinates of the box
 * AABB Max (Vector3) - The maximum value of the x, y, and z coordinates of the box
 * Target Point Position (Vector3)
 *
 * OUTPUTS: 
 * AABB Contains Point (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("86c817b0-c740-4d78-9ea1-ebb94d6e1cee")]
public class AABBContainsPoint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "AABB Contains Point";
    public string GetVariableQualifiedName() => "aABBContainsPoint";
}