/*
 * Filename: BitLeadingZeros.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Counts the number of zeros at the beginning (most significant side) of the binary representation of an integer.
 * Types: 
 * 
 * INPUTS: 
 * Value (int)
 *
 * OUTPUTS: 
 * Leading Zeros (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("d6e62624-06b0-416e-8e3c-ca058efd3c46")]
public class BitLeadingZeros : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Leading Zeros";
    public string GetVariableQualifiedName() => "bitLeadingZeros";
}