/*
 * Filename: LogAnalyticsEvent.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: 
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Payload (Analytics Payload)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("41cb0a75-01d1-40be-af97-ede1c6ee5830")]
public class LogAnalyticsEvent : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Log Analytics Event";
    public string GetVariableQualifiedName() => "logAnalyticsEvent";
}