/*
 * Filename: InverseLerp.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes an inverse linear interpolation. The output is clamped between 0 and 1.
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

[Node("9d811bd5-2a4a-4368-80ea-635004b6c06b")]
public class InverseLerp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Inverse Lerp";
    public string GetVariableQualifiedName() => "inverseLerp";
}