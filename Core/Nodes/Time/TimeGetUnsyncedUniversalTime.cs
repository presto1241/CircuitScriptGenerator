/*
 * Filename: TimeGetUnsyncedUniversalTime.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the UTC time. Uses local player's system clock. This is not synchronized between players!
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

[Node("f33e3fb6-79f1-43da-93c1-553d022b9f37")]
public class TimeGetUnsyncedUniversalTime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Time Get Unsynced Universal Time";
    public string GetVariableQualifiedName() => "timeGetUnsyncedUniversalTime";
}