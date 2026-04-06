/*
 * Filename: BitNand.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a bitwise NAND. (NOT AND) The result has a bit set for every bit that is not set in either of the inputs.
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

[Node("05305e33-a809-4751-b928-2c8a5bbc6dc9")]
public class BitNand : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit Nand";
    public string GetVariableQualifiedName() => "bitNand";
}