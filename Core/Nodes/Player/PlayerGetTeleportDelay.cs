/*
 * Filename: PlayerGetTeleportDelay.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the teleport delay for a given player
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Teleport Delay (s) (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("aa63bd19-b0a1-441f-8d69-71591d9007b9")]
public class PlayerGetTeleportDelay : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Teleport Delay";
    public string GetVariableQualifiedName() => "playerGetTeleportDelay";
}