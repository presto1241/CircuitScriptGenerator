/*
 * Filename: QuaternionDot.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: The dot product between two rotations.
 * Types: 
 * 
 * INPUTS: 
 * Lhs (Quaternion)
 * Rhs (Quaternion)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("268d931e-172b-48e8-8eb8-8ec2a9614f0d")]
public class QuaternionDot : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Dot";
    public string GetVariableQualifiedName() => "quaternionDot";
}