/*
 * Filename: SmoothDamp.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Moves a vector towards a target, with velocity based damping
 * Types: (float | Vector3)
 * 
 * INPUTS: 
 * Update (exec)
 * Current (T)
 * Target (T)
 * Current Velocity (T)
 * Smooth Time (float)
 * Max Speed (float)
 * Delta Time (float)
 *
 * OUTPUTS: 
 * Update (exec)
 * Result (T)
 * Result Velocity (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("830600a6-ec28-46b0-9354-13e0a1061232")]
public class SmoothDamp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Smooth Damp";
    public string GetVariableQualifiedName() => "smoothDamp";
}