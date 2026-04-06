/*
 * Filename: QuaternionCreateAngleAxis.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a rotation which rotates "Angle" degrees around "Axis".
 * Types: 
 * 
 * INPUTS: 
 * Angle (float)
 * Axis (Vector3)
 *
 * OUTPUTS: 
 * Result (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("d9096fb3-50c6-42f9-93bb-fc6df63d86a8")]
public class QuaternionCreateAngleAxis : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Create Angle Axis";
    public string GetVariableQualifiedName() => "quaternionCreateAngleAxis";
}