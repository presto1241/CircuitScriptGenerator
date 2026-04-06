/*
 * Filename: QuaternionCreateLook.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a rotation with the specified forward and upwards directions.
 * Types: 
 * 
 * INPUTS: 
 * Forward (Vector3)
 * Upwards (Vector3)
 *
 * OUTPUTS: 
 * Result (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("b28f369d-6758-4afc-80e2-8f09ea1df125")]
public class QuaternionCreateLook : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Create Look";
    public string GetVariableQualifiedName() => "quaternionCreateLook";
}