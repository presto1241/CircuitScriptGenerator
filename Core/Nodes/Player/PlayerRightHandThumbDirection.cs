/*
 * Filename: PlayerRightHandThumbDirection.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the direction of a Player's right hand thumb.
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

[Node("86e8581c-ddf9-4302-a06f-c451b5055a98")]
public class PlayerRightHandThumbDirection : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Right Hand Thumb Direction";
    public string GetVariableQualifiedName() => "playerRightHandThumbDirection";
}