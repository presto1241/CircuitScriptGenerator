/*
 * Filename: PlayerGetIsCrouching.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the given player is crouching
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Crouching (bool) - Whether the given player is crouching
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("97a006a4-10fc-43ab-b222-e1d9b3d09d61")]
public class PlayerGetIsCrouching : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Is Crouching";
    public string GetVariableQualifiedName() => "playerGetIsCrouching";
}