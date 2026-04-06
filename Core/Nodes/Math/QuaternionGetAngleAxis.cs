/*
 * Filename: QuaternionGetAngleAxis.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the rotation which rotates angle degrees around axis in degrees.
 * Types: 
 * 
 * INPUTS: 
 * Quaternion (Quaternion)
 *
 * OUTPUTS: 
 * Angle (float)
 * Axis (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("b415c3ce-5f9f-472b-8d70-daeb728b7c2d")]
public class QuaternionGetAngleAxis : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Get Angle Axis";
    public string GetVariableQualifiedName() => "quaternionGetAngleAxis";
}