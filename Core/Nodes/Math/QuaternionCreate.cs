/*
 * Filename: QuaternionCreate.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Manually create a quaternion. Congratulations, you have reached peak math.
 * Types: 
 * 
 * INPUTS: 
 * X (float)
 * Y (float)
 * Z (float)
 * W (float)
 *
 * OUTPUTS: 
 * Quaternion (Quaternion)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("cff17d2a-4333-41da-81ac-2825f25bf819")]
public class QuaternionCreate : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Create";
    public string GetVariableQualifiedName() => "quaternionCreate";
}