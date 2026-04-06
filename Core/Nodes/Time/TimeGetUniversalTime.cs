/*
 * Filename: TimeGetUniversalTime.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the UTC time. Uses server's clock. This will be synchronized between players.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Year (int)
 * Month (int)
 * Day (int)
 * Hour (int)
 * Minute (int)
 * Second (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Time;

[Node("1b220886-d851-474c-a79e-0a18d0893ee9")]
public class TimeGetUniversalTime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Time Get Universal Time";
    public string GetVariableQualifiedName() => "timeGetUniversalTime";
}