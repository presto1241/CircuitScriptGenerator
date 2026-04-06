/*
 * Filename: ClosestPointOnLineSegment.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the closest point on a finite line segment to another given point and the line direction
 * Types: 
 * 
 * INPUTS: 
 * Start Point (Vector3)
 * End Point (Vector3)
 * Target Point (Vector3)
 *
 * OUTPUTS: 
 * Closest Point (Vector3)
 * Line Segment Direction (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b5d229df-e576-486c-9973-a8e31eba61c3")]
public class ClosestPointOnLineSegment : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Closest Point On Line Segment";
    public string GetVariableQualifiedName() => "closestPointOnLineSegment";
}