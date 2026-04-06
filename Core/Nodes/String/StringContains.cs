/*
 * Filename: StringContains.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the target string contains the input value.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 * Sequence (string)
 *
 * OUTPUTS: 
 * Result (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("aa24edab-c707-4cff-8c73-07e479b4cd07")]
public class StringContains : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Contains";
    public string GetVariableQualifiedName() => "stringContains";
}