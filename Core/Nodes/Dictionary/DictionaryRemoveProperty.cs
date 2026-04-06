/*
 * Filename: DictionaryRemoveProperty.cs
 * Category: Dictionary
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Removes a property from a Dictionary. After using this chip, you will no longer be able to get that property from that Dictionary until it is added again.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Dictionary (Dictionary)
 * Name (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Dictionary;

[Node("79bd9269-4733-436f-9f6d-6e611f4af9eb")]
public class DictionaryRemoveProperty : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dictionary Remove Property";
    public string GetVariableQualifiedName() => "dictionaryRemoveProperty";
}