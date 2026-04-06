/*
 * Filename: DictionaryVariable.cs
 * Category: Dictionary
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A variable for storing Dictionaries.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Dictionary)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * (unnamed) (Dictionary)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Dictionary;

[Node("bb2a004e-ca7c-48a1-9c34-eaf279602fac")]
public class DictionaryVariable : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Dictionary Variable";
    public string GetVariableQualifiedName() => "dictionaryVariable";
}