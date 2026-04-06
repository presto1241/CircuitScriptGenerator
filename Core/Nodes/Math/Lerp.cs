/*
 * Filename: Lerp.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a linear interpolation. The interpolant is clamped between 0 and 1.
 * Types: (float | Quaternion | Vector3 | Color)
 * 
 * INPUTS: 
 * Start (T)
 * End (T)
 * Progress (float)
 *
 * OUTPUTS: 
 * Result (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("91b0ffa8-4eb1-4a30-aaf3-7a049071cb42")]
public class Lerp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Lerp";
    public string GetVariableQualifiedName() => "lerp";
}