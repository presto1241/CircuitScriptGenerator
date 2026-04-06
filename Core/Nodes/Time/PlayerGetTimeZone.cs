/*
 * Filename: PlayerGetTimeZone.cs
 * Category: Time
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the offset of the given player's local time zone from UTC in seconds.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Seconds from UTC (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Time;

[Node("2d675f16-502a-489e-8fed-161935f32c04")]
public class PlayerGetTimeZone : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Time Zone";
    public string GetVariableQualifiedName() => "playerGetTimeZone";
}