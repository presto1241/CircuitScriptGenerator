/*
 * Filename: InverseLerpUnclamped.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes an inverse linear interpolation. The output is not clamped.
 * Types: (float | Color | Vector3)
 * 
 * INPUTS: 
 * Start (T)
 * End (T)
 * Value (T)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("d33e7a63-ec6b-40b2-9f81-ab110457a9f2")]
public class InverseLerpUnclamped : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inverse Lerp Unclamped";
    public string GetVariableQualifiedName() => "inverseLerpUnclamped";
}