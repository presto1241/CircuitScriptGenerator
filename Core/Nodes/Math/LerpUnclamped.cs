/*
 * Filename: LerpUnclamped.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a linear interpolation. The interpolant is not clamped. When lerping between Colors, the interpolant is still constrained to values which stay within the set of real colors.
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

[Node("6e9219ab-89d2-47e3-a105-562a9a1fddda")]
public class LerpUnclamped : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Lerp Unclamped";
    public string GetVariableQualifiedName() => "lerpUnclamped";
}