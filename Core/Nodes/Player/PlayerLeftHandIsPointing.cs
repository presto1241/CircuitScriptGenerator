/*
 * Filename: PlayerLeftHandIsPointing.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs whether or not a Player's left hand is pointing.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Is Pointing (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("b17ee6b2-768c-46a2-8cd3-721ab2af9290")]
public class PlayerLeftHandIsPointing : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Left Hand Is Pointing";
    public string GetVariableQualifiedName() => "playerLeftHandIsPointing";
}