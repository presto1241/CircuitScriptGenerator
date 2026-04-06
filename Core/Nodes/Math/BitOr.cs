/*
 * Filename: BitOr.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a bitwise OR. The result has a bit set for every bit that is set in either of the inputs.
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

[Node("2c24bc11-9543-4738-8c6c-0c5e3fadd944")]
public class BitOr : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Or";
    public string GetVariableQualifiedName() => "bitOr";
}