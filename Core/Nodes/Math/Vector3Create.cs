/*
 * Filename: Vector3Create.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a new vector from X, Y, Z values.
 * Types: 
 * 
 * INPUTS: 
 * X (float)
 * Y (float)
 * Z (float)
 *
 * OUTPUTS: 
 * Vector3 (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("814e9337-7542-4851-9da0-c73885ab0b4f")]
public class Vector3Create : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Vector3 Create";
    public string GetVariableQualifiedName() => "vector3Create";
}