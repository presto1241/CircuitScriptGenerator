/*
 * Filename: StringToLower.cs
 * Category: String
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the target string in lower case.
 * Types: 
 * 
 * INPUTS: 
 * String (string)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.String;

[Node("678f6d33-1e94-4be6-b959-0212c1a2207f")]
public class StringToLower : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "String To Lower";
    public string GetVariableQualifiedName() => "stringToLower";
}