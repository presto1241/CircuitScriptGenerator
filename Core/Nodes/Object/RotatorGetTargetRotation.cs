/*
 * Filename: RotatorGetTargetRotation.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the rotation of the Marker on the target Rotator in degrees.
 * Types: 
 * 
 * INPUTS: 
 * Target (Rotator)
 *
 * OUTPUTS: 
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("117b8c83-5ada-4665-a0c6-2c6ffdec98b9")]
public class RotatorGetTargetRotation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rotator Get Target Rotation";
    public string GetVariableQualifiedName() => "rotatorGetTargetRotation";
}