/*
 * Filename: QuaternionCreateFromTo.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a rotation which rotates from "From" to "To".
 * Types: 
 * 
 * INPUTS: 
 * From (Vector3)
 * To (Vector3)
 *
 * OUTPUTS: 
 * Result (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("1069c5de-c7e3-40e0-bd90-52135873b36d")]
public class QuaternionCreateFromTo : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Create From To";
    public string GetVariableQualifiedName() => "quaternionCreateFromTo";
}