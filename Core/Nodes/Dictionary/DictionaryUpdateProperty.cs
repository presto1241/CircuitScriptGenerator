/*
 * Filename: DictionaryUpdateProperty.cs
 * Category: Dictionary
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates or updates a property in a Dictionary. The new property value is guaranteed to be stomped in without any type checking, which could break existing circuits if it changes the type of an existing property
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Dictionary (Dictionary)
 * Name (string)
 * Value (T)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Dictionary;

[Node("7b776c2a-0d52-4026-9e00-0c70e9175af5")]
public class DictionaryUpdateProperty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dictionary Update Property";
    public string GetVariableQualifiedName() => "dictionaryUpdateProperty";
}