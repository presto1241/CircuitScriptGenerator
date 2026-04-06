/*
 * Filename: LocalPlayerRequestFOVMultiplier.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Requests a particular field-of-view (FOV) multiplier for the local player. This multiplier stacks with other FOV changes Rec Room makes. For example, sprinting will have an additional effect even if this chip is in effect.
This chip does not affect players in VR. Other systems in the game, like the watch, may override this chip or prevent a request from being honored. Players may also opt out of FOV changes for their comfort. If FOV changes are important to your room, consider advising players to enable FOV changes in their settings.
The multiplier must be in the range [0.75, 1.25], and Duration must be a value larger than 0.0167. You are allowed to request a new FOV 4 times within 1 second. If these limits are exceeded, this chip will issue a warning, not an error. These limits may change as we tune the chip during its beta.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * FOV Multiplier (float)
 * Transition Duration (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("1136eb2f-8e2b-414b-9d82-f33e4e79c75a")]
public class LocalPlayerRequestFOVMultiplier : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Request FOV Multiplier";
    public string GetVariableQualifiedName() => "localPlayerRequestFOVMultiplier";
}