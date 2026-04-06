/*
 * Filename: BitAnd.cs
 * Category: Math
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Computes a bitwise AND. The result has a bit set for every bit that is set in both of the inputs.
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

[Node("28a95bc3-ab08-48ae-b0c0-16b41168bf47")]
public class BitAnd : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Bit And";
    public string GetVariableQualifiedName() => "bitAnd";
}