/*
 * Filename: StringFormat.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Use this chip to combine multiple strings together into a single string output. The "Format" input is part of final string output and can include other string inputs by using this syntax: {input pin # starting at 0}. For example, a "Format" input with a default value of “Hello, {0}!” with a single additional input pin with the value "World" is fully output as "Hello, World!". If you had another input pin you would use {1} to denote the 2nd pin. You can add more string inputs by configuring the chip and pressing "Add Input".
 * Types: 
 * 
 * INPUTS: 
 * Format (string)
 * Value (string)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("77afc9dd-baa9-4312-b8b8-7ef479c840e6")]
public class StringFormat : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Format";
    public string GetVariableQualifiedName() => "stringFormat";
}