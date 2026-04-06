/*
 * Filename: PlayerLeftHandThumbDirection.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the direction of a Player's left hand thumb.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Vector (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("fc2a0141-4997-422c-bdd3-f7ecd7d4c996")]
public class PlayerLeftHandThumbDirection : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Left Hand Thumb Direction";
    public string GetVariableQualifiedName() => "playerLeftHandThumbDirection";
}