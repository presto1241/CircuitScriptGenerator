/*
 * Filename: PlayerGetTeleportDistance.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the max teleport distance for a given player
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Teleport Distance (m) (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("08b53553-0368-4de9-bb59-57a4e2fdb2b2")]
public class PlayerGetTeleportDistance : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Teleport Distance";
    public string GetVariableQualifiedName() => "playerGetTeleportDistance";
}