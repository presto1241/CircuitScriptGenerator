/*
 * Filename: TimeGetUnsyncedUniversalSeconds.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the number of seconds since 1970. Uses local player's system clock. This is not synchronized between players! This is also not guaranteed to be continuous. To measure time, use Time Get Precise Seconds instead.
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

[Node("d46f6fdc-480c-41e6-9a27-87fadb0ab0fc")]
public class TimeGetUnsyncedUniversalSeconds : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Time Get Unsynced Universal Seconds";
    public string GetVariableQualifiedName() => "timeGetUnsyncedUniversalSeconds";
}