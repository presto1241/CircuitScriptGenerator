/*
 * Filename: Atan2.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes the 2-argument arctangent of a number in degrees.
 * Types: 
 * 
 * INPUTS: 
 * Y (float)
 * X (float)
 *
 * OUTPUTS: 
 * Result (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("02d62908-550d-4f8b-8bc7-0960fb1b547f")]
public class Atan2 : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Atan2";
    public string GetVariableQualifiedName() => "atan2";
}