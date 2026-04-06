/*
 * Filename: RandomFromListDeprecated.cs
 * Category: List
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs a random value from a target list.
 * Types: any
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * List (List<T>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Value (T)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.List;

[Node("0b18cef3-0ea5-4e3c-a0d5-c460f03dbe8c")]
public class RandomFromListDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Random From List (Deprecated)";
    public string GetVariableQualifiedName() => "randomFromListDeprecated";
}