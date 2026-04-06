/*
 * Filename: BitRotateRight.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Rotates digits in the binary representation of an integer to the right. As the rightmost bits fall off, they are used to fill the leftmost bits.
 * Types: 
 * 
 * INPUTS: 
 * Value (int)
 * Shift (int) - Number of bits to rotate
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("b5f36fdf-0a2e-489a-bbdf-f17c50974cc1")]
public class BitRotateRight : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Rotate Right";
    public string GetVariableQualifiedName() => "bitRotateRight";
}