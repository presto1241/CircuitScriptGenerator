/*
 * Filename: GetFormattedTime.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the given universal time, formatted based on the C# DateTime format specifiers.
 * Types: (float | int)
 * 
 * INPUTS: 
 * Universal Seconds (T)
 * Format (string)
 *
 * OUTPUTS: 
 * Result (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Time;

[Node("7dfed109-e641-47f3-8844-fd0753e4e764")]
public class GetFormattedTime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Formatted Time";
    public string GetVariableQualifiedName() => "getFormattedTime";
}