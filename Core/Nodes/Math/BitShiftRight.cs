/*
 * Filename: BitShiftRight.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Shifts a value right by a number of bits. Rightmost bits are discarded, and leftmost bits are filled with zeros. (Logical shift)
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

[Node("4024b483-ab3d-4fa0-b399-b3350b800081")]
public class BitShiftRight : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Shift Right";
    public string GetVariableQualifiedName() => "bitShiftRight";
}