/*
 * Filename: PlayerGetIsAFK.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether or not the player is AFK. This occurs when the player has not been active in the room for some time.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Is AFK (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7e87720d-2720-4819-82f6-8d44590e9e65")]
public class PlayerGetIsAFK : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is AFK";
    public string GetVariableQualifiedName() => "playerGetIsAFK";
}