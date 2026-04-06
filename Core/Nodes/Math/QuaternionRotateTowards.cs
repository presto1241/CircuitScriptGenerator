/*
 * Filename: QuaternionRotateTowards.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Rotates a rotation from "From" towards "To".
 * Types: 
 * 
 * INPUTS: 
 * From (Quaternion)
 * To (Quaternion)
 * MaxDegreesDelta (float)
 *
 * OUTPUTS: 
 * Result (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("edfe7cbb-6973-4489-9b7a-75746243dd6d")]
public class QuaternionRotateTowards : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Rotate Towards";
    public string GetVariableQualifiedName() => "quaternionRotateTowards";
}