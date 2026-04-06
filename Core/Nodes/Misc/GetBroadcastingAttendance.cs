/*
 * Filename: GetBroadcastingAttendance.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs player counts if you're in an event that's actively broadcasting.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Audience Count (int) - Number of players watching a broadcast at this event
 * Broadcaster Count (int) - Number of players broadcasting themselves at this event
 * Is Broadcast Active (bool) - True if anyone is broadcasting. Only active broadcasts will have accurate attendance counts
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("78f5a9f2-4e3d-4534-aada-4af3a551a953")]
public class GetBroadcastingAttendance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Broadcasting Attendance";
    public string GetVariableQualifiedName() => "getBroadcastingAttendance";
}