/*
 * Filename: PlayerRightHandIsPointing.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs whether or not a Player's right hand is pointing.
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

[Node("a8ed9cb0-caa3-487d-b5a3-f0161433af56")]
public class PlayerRightHandIsPointing : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Right Hand Is Pointing";
    public string GetVariableQualifiedName() => "playerRightHandIsPointing";
}