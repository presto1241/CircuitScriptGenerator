/*
 * Filename: StringLength.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the length of a target string in UTF-16 characters.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 *
 * OUTPUTS: 
 * Length (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("dcde9345-00f2-41fb-9a2d-5a938f39bfb5")]
public class StringLength : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Length";
    public string GetVariableQualifiedName() => "stringLength";
}