/*
 * Filename: ParseColor.cs
 * Category: Conversion
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Attempt to parse the given string as a hexadecimal color in the '#RRGGBB' format.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 *
 * OUTPUTS: 
 * Result (Color)
 * Parse Success (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Conversion;

[Node("7a36c4b7-fb89-4ddc-a3b2-bff8597f7b17")]
public class ParseColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Parse Color";
    public string GetVariableQualifiedName() => "parseColor";
}