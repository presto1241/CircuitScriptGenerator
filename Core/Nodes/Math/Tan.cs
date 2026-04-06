/*
 * Filename: Tan.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes the tangent of a number in degrees.
 * Types: 
 * 
 * INPUTS: 
 * Value (float)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("13dbbd78-11c0-4b4f-9098-1ef59e584324")]
public class Tan : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Tan";
    public string GetVariableQualifiedName() => "tan";
}