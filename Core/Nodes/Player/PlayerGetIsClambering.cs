/*
 * Filename: PlayerGetIsClambering.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Whether or not the player is currently clambering or mantling up a ledge
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

[Node("fea61975-90b0-4187-b28a-b732a14834c0")]
public class PlayerGetIsClambering : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Clambering";
    public string GetVariableQualifiedName() => "playerGetIsClambering";
}