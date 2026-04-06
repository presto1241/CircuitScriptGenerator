/*
 * Filename: VerticalCylinderContainsPoint.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Check whether a point is inside a vertical cylinder
 * Types: 
 * 
 * INPUTS: 
 * Center (Vector3) - The center point of the cylinder
 * Radius (float) - The radius of the cylinder
 * Height (float) - The height of the cylinder
 * Point (Vector3)
 *
 * OUTPUTS: 
 * Vertical Cylinder Contains Point (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("01c93a94-509f-4da7-b8b7-27539df06e4a")]
public class VerticalCylinderContainsPoint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vertical Cylinder Contains Point";
    public string GetVariableQualifiedName() => "verticalCylinderContainsPoint";
}