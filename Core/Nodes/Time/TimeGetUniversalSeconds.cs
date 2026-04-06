/*
 * Filename: TimeGetUniversalSeconds.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the number of seconds since 1970. Uses server's clock. This will be synchronized between players. This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Time;

[Node("bc3059d8-b613-4e91-ac7f-4c3566e01dc2")]
public class TimeGetUniversalSeconds : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Time Get Universal Seconds";
    public string GetVariableQualifiedName() => "timeGetUniversalSeconds";
}