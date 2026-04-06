/*
 * Filename: PlayerGetIsGrounded.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the given player is grounded, a.k.a. not jumping, flying, wall-running, clambering, or falling. Also returns the time (in seconds) since they were last grounded, or 0 if currently grounded. Surface Object returns the Room Object that the player is standing on if they are grounded, or Invalid Object if the player is not grounded or standing on a non-Rec Room Object. Surface Normal returns the normal of the surface if the player is grounded and (0, 1, 0) if they're not.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Grounded (bool) - Whether the given player is grounded, a.k.a. not jumping, flying, wall-running, clambering, or falling
 * Time Since Last Grounded (float) - The time (in seconds) since the player was last grounded, or 0 if currently grounded
 * Surface Object (Rec Room Object) - Surface Object returns the Room Object that the player is standing on if they are grounded, or Invalid Object if the player is not grounded or standing on a non-Rec Room Object.
 * Surface Normal (Vector3) - Surface Normal returns the normal of the surface if the player is grounded and (0, 1, 0) if they're not.
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("4db35e9d-3a1d-4823-a011-7f94e028a3e7")]
public class PlayerGetIsGrounded : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Grounded";
    public string GetVariableQualifiedName() => "playerGetIsGrounded";
}