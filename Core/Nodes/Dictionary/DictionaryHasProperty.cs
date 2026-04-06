/*
 * Filename: DictionaryHasProperty.cs
 * Category: Dictionary
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: True if the specified property exists in the specified Dictionary; otherwise, false.
 * Types: 
 * 
 * INPUTS: 
 * Dictionary (Dictionary)
 * Name (string)
 *
 * OUTPUTS: 
 * Has Property (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Dictionary;

[Node("e7f529fa-192e-432d-9c63-35f897cad6c3")]
public class DictionaryHasProperty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dictionary Has Property";
    public string GetVariableQualifiedName() => "dictionaryHasProperty";
}