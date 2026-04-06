/*
 * Filename: Vector3Mask.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Keeps or zeroes out the values of each dimension of a Vector3. A "keep" value of True keeps the value passed in. A keep value of false sets that dimension's value to 0.
 * Types: 
 * 
 * INPUTS: 
 * Vector (Vector3)
 * Keep X (bool)
 * Keep Y (bool)
 * Keep Z (bool)
 *
 * OUTPUTS: 
 * Result (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("2d9a57ad-2f62-4d2d-bee0-addf792dd9d6")]
public class Vector3Mask : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Mask";
    public string GetVariableQualifiedName() => "vector3Mask";
}