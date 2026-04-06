/*
 * Filename: PlayerGetCanTeleport.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether a given player is allowed to teleport.

Note: The value of this property is independent of a player's platform. (This value can be true for screens players.)
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Can Teleport (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("52fcfdc0-5f37-4c4c-892a-f61ba6ebf686")]
public class PlayerGetCanTeleport : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Can Teleport";
    public string GetVariableQualifiedName() => "playerGetCanTeleport";
}