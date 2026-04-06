/*
 * Filename: BitXor.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a bitwise XOR. The result has a bit set for every bit that is set in exactly one of the inputs.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (int)
 * (unnamed) (int)
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("a3899394-1ed9-4d41-a836-22fffaf4e90d")]
public class BitXor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Xor";
    public string GetVariableQualifiedName() => "bitXor";
}