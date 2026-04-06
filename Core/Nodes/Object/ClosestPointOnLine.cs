/*
 * Filename: ClosestPointOnLine.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return the closest point on a infinite line to another given point
 * Types: 
 * 
 * INPUTS: 
 * Point 1 (Vector3)
 * Point 2 (Vector3)
 * Target Point (Vector3)
 *
 * OUTPUTS: 
 * Closest Point (Vector3)
 * Line Direction (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3f697089-f4ff-4ac2-bd39-95680c4f877b")]
public class ClosestPointOnLine : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Closest Point On Line";
    public string GetVariableQualifiedName() => "closestPointOnLine";
}