/*
 * Filename: DictionaryGetProperty.cs
 * Category: Dictionary
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the property with the specified name from the Dictionary. The chip will error if the type of the requested property doesn't match the value requested by the output port.
 * Types: any
 * 
 * INPUTS: 
 * Dictionary (Dictionary)
 * Name (string)
 *
 * OUTPUTS: 
 * Value (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Dictionary;

[Node("2757aea8-203d-4c8f-97e9-acb1d7f8aa4f")]
public class DictionaryGetProperty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dictionary Get Property";
    public string GetVariableQualifiedName() => "dictionaryGetProperty";
}