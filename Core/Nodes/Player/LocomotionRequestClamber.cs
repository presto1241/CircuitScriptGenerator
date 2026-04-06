/*
 * Filename: LocomotionRequestClamber.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Request that the local player perform a clamber or a mantle. Custom Locomotion must be enabled in the active Player Definition Board.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Ledge Position (Vector3) - The position that the clamber will end up
 * Wall Normal (Vector3) - The normal of the wall that the player is clambering up. Only used for better clambering up moving surfaces.
 * Wall Object (Rec Room Object) - The wall that the player is clambering up
 * Mantle (bool) - Whether this is a Clamber or a Mantle. This affects the animation used.
 * Duration (float) - How long the clamber should last
 * Post Clamber Velocity Multiplier (float) - A value between 0 and 1. If 0, the player will come to a complete stop after the clamber. If 1, the player's speed after the clamber will be unaffected.
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("b179742a-bdd8-47b5-b439-6cdd5cf9484a")]
public class LocomotionRequestClamber : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Locomotion Request Clamber";
    public string GetVariableQualifiedName() => "locomotionRequestClamber";
}