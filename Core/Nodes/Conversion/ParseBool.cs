/*
 * Filename: ParseBool.cs
 * Category: Conversion
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Converts the input string to a bool if able.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 *
 * OUTPUTS: 
 * Result (bool)
 * Parse Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Conversion;

[Node("92c05ebc-1967-49a4-94b5-2d01fe1e6b85")]
public class ParseBool : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Parse Bool";
    public string GetVariableQualifiedName() => "parseBool";
}