/*
 * Filename: StringSubstring.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Allows you to extract individual parts from a string. You can think of this like a list of characters.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 * Index (int)
 * Length (int)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("226fafe2-1ea8-4ae8-861e-ae4b1bd10bfe")]
public class StringSubstring : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Substring";
    public string GetVariableQualifiedName() => "stringSubstring";
}