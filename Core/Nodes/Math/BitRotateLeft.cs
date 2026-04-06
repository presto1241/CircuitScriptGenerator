/*
 * Filename: BitRotateLeft.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Rotates digits in the binary representation of an integer to the left. As the leftmost bits fall off, they are used to fill the rightmost bits.
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

[Node("bd013fe7-3799-46b5-b1f3-66a3f5add5ed")]
public class BitRotateLeft : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Rotate Left";
    public string GetVariableQualifiedName() => "bitRotateLeft";
}