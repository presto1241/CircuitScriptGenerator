/*
 * Filename: StringIndexOf.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the index where the substring starts in the target string.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 * Substring (string)
 *
 * OUTPUTS: 
 * Index (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("1af21999-38f8-4231-9de9-26b43f47fe0d")]
public class StringIndexOf : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Index Of";
    public string GetVariableQualifiedName() => "stringIndexOf";
}