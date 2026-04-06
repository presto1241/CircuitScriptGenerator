/*
 * Filename: Vector3Split.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Breaks the X, Y, and Z values out of the input vector.
 * Types: 
 * 
 * INPUTS: 
 * Vector3 (Vector3)
 *
 * OUTPUTS: 
 * X (float)
 * Y (float)
 * Z (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("2d677241-61b7-45d2-aec2-4a302e3483a0")]
public class Vector3Split : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Split";
    public string GetVariableQualifiedName() => "vector3Split";
}