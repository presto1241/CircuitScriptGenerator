/*
 * Filename: TimeGetPreciseSeconds.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the amount of seconds since a player launched Rec Room.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Time;

[Node("8722445f-e552-4d4a-bced-8afa63bbf70b")]
public class TimeGetPreciseSeconds : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Time Get Precise Seconds";
    public string GetVariableQualifiedName() => "timeGetPreciseSeconds";
}