/*
 * Filename: ToString.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Converts the input value to the string type. Example: the integer input 10 would output "10" as a string. Helpful for debugging purposes.
 * Types: any
 * 
 * INPUTS: 
 * Value (T)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("bddc8e4e-b496-48ee-8e25-5b9fe8e1c6c9")]
public class ToString : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "To String";
    public string GetVariableQualifiedName() => "toString";
}