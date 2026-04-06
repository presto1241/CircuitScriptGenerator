/*
 * Filename: BitShiftLeft.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Shifts a value left by a number of bits. Leftmost bits are discarded, and rightmost bits are filled with zeros.
 * Types: 
 * 
 * INPUTS: 
 * Value (int)
 * Shift (int) - Shift count. The actual shift performed will be this value mod 32.
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("0a7b4058-b1da-442f-8341-81df66979663")]
public class BitShiftLeft : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Shift Left";
    public string GetVariableQualifiedName() => "bitShiftLeft";
}