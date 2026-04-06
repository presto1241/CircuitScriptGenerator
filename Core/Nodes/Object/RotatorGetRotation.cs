/*
 * Filename: RotatorGetRotation.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the rotation of a target Rotator in degrees.
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

[Node("30fe0829-2f08-4bd2-b4b1-9a41764e5a76")]
public class RotatorGetRotation : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rotator Get Rotation";
    public string GetVariableQualifiedName() => "rotatorGetRotation";
}