/*
 * Filename: QuaternionCreateEulerAngles.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a quaternion from euler angles specified in degrees.
 * Types: 
 * 
 * INPUTS: 
 * Angles (Vector3)
 *
 * OUTPUTS: 
 * Result (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("e320278c-13f0-4fe3-b838-7e671bdd9b49")]
public class QuaternionCreateEulerAngles : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Create Euler Angles";
    public string GetVariableQualifiedName() => "quaternionCreateEulerAngles";
}