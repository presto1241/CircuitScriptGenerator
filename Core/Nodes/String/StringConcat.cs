/*
 * Filename: StringConcat.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Concatenate a given series of strings in order, with an optional separator.
 * Types: 
 * 
 * INPUTS: 
 * Separator (string)
 * Value (string)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("73ed7ea2-cead-405a-b39c-1fec4bfd4236")]
public class StringConcat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Concat";
    public string GetVariableQualifiedName() => "stringConcat";
}