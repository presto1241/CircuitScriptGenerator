/*
 * Filename: StringSplit.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Splits the target string at the input character.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 * Divider (string)
 *
 * OUTPUTS: 
 * List (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("ad169649-1050-48c5-a540-f03a2059bcdb")]
public class StringSplit : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Split";
    public string GetVariableQualifiedName() => "stringSplit";
}