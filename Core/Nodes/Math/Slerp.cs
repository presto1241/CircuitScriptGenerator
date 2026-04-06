/*
 * Filename: Slerp.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Spherically interpolates between quaternions or Vector3s "Start" and "End". Progress is 0 to 1. Also a rare, but refreshing beverage.
 * Types: (Quaternion | Vector3)
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

[Node("8d5f0586-1ecf-42ba-a34f-c6ccbb0eadb9")]
public class Slerp : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Slerp";
    public string GetVariableQualifiedName() => "slerp";
}