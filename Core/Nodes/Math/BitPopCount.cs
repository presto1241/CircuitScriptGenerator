/*
 * Filename: BitPopCount.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Counts the number of set bits in the binary representation of an integer.
 * Types: 
 * 
 * INPUTS: 
 * Value (int)
 *
 * OUTPUTS: 
 * Population (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("6982e235-5814-4c5a-8bc8-fdbcc9a73eb8")]
public class BitPopCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Pop Count";
    public string GetVariableQualifiedName() => "bitPopCount";
}