/*
 * Filename: SnapPointGetSnappedSnapPoint.cs
 * Category: Snap Point
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the Snap Point currently snapped to the input (or an invalid Snap Point if the input isn't currently snapped).
 * Types: 
 * 
 * INPUTS: 
 * Snap Point (Snap Point) - The Snap Point to test.
 *
 * OUTPUTS: 
 * Other Snap Point (Snap Point) - The Snap Point currently snapped to the input (or an invalid Snap Point if the input isn't currently snapped).
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.SnapPoint;

[Node("d863debb-14ec-45ab-9355-041f993db124")]
public class SnapPointGetSnappedSnapPoint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Snap Point Get Snapped Snap Point";
    public string GetVariableQualifiedName() => "snapPointGetSnappedSnapPoint";
}