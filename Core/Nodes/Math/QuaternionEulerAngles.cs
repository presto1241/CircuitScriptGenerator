/*
 * Filename: QuaternionEulerAngles.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the input quaternion as a vector3 of euler angles specified in degrees.
 * Types: 
 * 
 * INPUTS: 
 * Value (Quaternion)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("81048ea5-2778-4816-99c5-1c50faad8a87")]
public class QuaternionEulerAngles : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Euler Angles";
    public string GetVariableQualifiedName() => "quaternionEulerAngles";
}