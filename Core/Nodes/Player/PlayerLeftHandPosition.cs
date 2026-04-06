/*
 * Filename: PlayerLeftHandPosition.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the postion of a Player's left hand in world space.
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

[Node("619b3bc8-bcb9-4812-86f5-f6442cdbb557")]
public class PlayerLeftHandPosition : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Left Hand Position";
    public string GetVariableQualifiedName() => "playerLeftHandPosition";
}