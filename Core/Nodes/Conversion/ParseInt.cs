/*
 * Filename: ParseInt.cs
 * Category: Conversion
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Converts the input string to a integer if able.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 *
 * OUTPUTS: 
 * Result (int)
 * Parse Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Conversion;

[Node("00b49995-a322-47a3-a32b-5530f2ba7fed")]
public class ParseInt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Parse Int";
    public string GetVariableQualifiedName() => "parseInt";
}