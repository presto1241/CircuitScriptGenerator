/*
 * Filename: QuaternionSplit.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Split a quaternion into its four float components: x, y, z, and w. Congratulations, you have reached peak math.
 * Types: 
 * 
 * INPUTS: 
 * Quaternion (Quaternion)
 *
 * OUTPUTS: 
 * X (float)
 * Y (float)
 * Z (float)
 * W (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("1d2a37e1-428e-4385-bc96-4ad5adff0a05")]
public class QuaternionSplit : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Quaternion Split";
    public string GetVariableQualifiedName() => "quaternionSplit";
}