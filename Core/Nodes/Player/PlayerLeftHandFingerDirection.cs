/*
 * Filename: PlayerLeftHandFingerDirection.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the direction of a Player's left hand finger.
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

[Node("6b5c4b0b-be26-4055-b26f-1e5f061c63ca")]
public class PlayerLeftHandFingerDirection : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Left Hand Finger Direction";
    public string GetVariableQualifiedName() => "playerLeftHandFingerDirection";
}