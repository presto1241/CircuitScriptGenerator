/*
 * Filename: PlayerGetIsWallClimbing.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets whether the player is currently in the Wall Climb state.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Clambering (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("2966113d-4046-462d-8fd1-62a5e0492ea6")]
public class PlayerGetIsWallClimbing : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Wall Climbing";
    public string GetVariableQualifiedName() => "playerGetIsWallClimbing";
}