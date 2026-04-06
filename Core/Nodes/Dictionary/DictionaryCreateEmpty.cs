/*
 * Filename: DictionaryCreateEmpty.cs
 * Category: Dictionary
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a new empty Dictionary every time the output port is accessed. A Dictionary is a collection of Properties, each of which has a name, a type, and a value.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Dictionary (Dictionary)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Dictionary;

[Node("813beaf0-79b5-4547-86a8-5d84920258bd")]
public class DictionaryCreateEmpty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dictionary Create Empty";
    public string GetVariableQualifiedName() => "dictionaryCreateEmpty";
}