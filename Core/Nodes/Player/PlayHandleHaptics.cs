/*
 * Filename: PlayHandleHaptics.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Plays haptic feedback through a held Handle object Duration is an integer in milliseconds between 1 and 500 Intensity is a float value from 0 to 1  At this time, haptics are only supported on VR. 
 * Types: 
 * 
 * INPUTS: 
 * Play (exec)
 * Handle (Handle)
 * Duration (ms) (int)
 * Intensity (float)
 *
 * OUTPUTS: 
 * Play (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("da6980ad-92eb-4ce8-a643-291e2bf82bc7")]
public class PlayHandleHaptics : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Play Handle Haptics";
    public string GetVariableQualifiedName() => "playHandleHaptics";
}