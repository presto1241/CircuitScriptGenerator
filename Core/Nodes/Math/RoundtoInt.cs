/*
 * Filename: RoundtoInt.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Rounds an input value to the nearest integer.
 * Types: 
 * 
 * INPUTS: 
 * Value (float)
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("0d2a4771-0694-4b84-8e07-2080c26aae22")]
public class RoundtoInt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Round to Int";
    public string GetVariableQualifiedName() => "roundtoInt";
}