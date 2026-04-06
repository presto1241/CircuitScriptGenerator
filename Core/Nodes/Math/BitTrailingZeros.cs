/*
 * Filename: BitTrailingZeros.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Counts the number of zeros at the end (least significant side) of the binary representation of an integer.
 * Types: 
 * 
 * INPUTS: 
 * Value (int)
 *
 * OUTPUTS: 
 * Trailing Zeros (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("773d361e-3761-497b-9dec-b5e5313a5a2c")]
public class BitTrailingZeros : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Trailing Zeros";
    public string GetVariableQualifiedName() => "bitTrailingZeros";
}