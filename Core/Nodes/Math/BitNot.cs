/*
 * Filename: BitNot.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a bitwise NOT. The result has a bit set for every bit that is not set in the input.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (int)
 *
 * OUTPUTS: 
 * Result (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Math;

[Node("ec74ea41-24e5-491c-8919-a502638583f9")]
public class BitNot : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Not";
    public string GetVariableQualifiedName() => "bitNot";
}