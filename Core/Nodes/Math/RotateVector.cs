/*
 * Filename: RotateVector.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Rotate a Vector3 with a Quaternion.
 * Types: 
 * 
 * INPUTS: 
 * Rotation (Quaternion)
 * Point (Vector3)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("02c4048a-5f67-47ea-9f00-692f51c66e65")]
public class RotateVector : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Rotate Vector";
    public string GetVariableQualifiedName() => "rotateVector";
}