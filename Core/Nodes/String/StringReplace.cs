/*
 * Filename: StringReplace.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Replaces all instances of pattern within string with replacement.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 * Pattern (string)
 * Replacement (string)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("b394650e-7673-40a3-8b9e-3aa8eaa2a77e")]
public class StringReplace : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String Replace";
    public string GetVariableQualifiedName() => "stringReplace";
}