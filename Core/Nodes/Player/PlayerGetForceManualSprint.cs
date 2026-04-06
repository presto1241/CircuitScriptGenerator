/*
 * Filename: PlayerGetForceManualSprint.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether manual sprint is required for a given player
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Force Manual Sprint (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7b099bfd-965c-4d78-9e7b-59114bf64dbb")]
public class PlayerGetForceManualSprint : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Force Manual Sprint";
    public string GetVariableQualifiedName() => "playerGetForceManualSprint";
}