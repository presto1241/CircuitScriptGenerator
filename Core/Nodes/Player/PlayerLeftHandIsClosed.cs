/*
 * Filename: PlayerLeftHandIsClosed.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs whether or not a Player's left hand is closed.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Is Closed (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("3036e63f-f29b-4ee5-882e-72bf36a8e0f9")]
public class PlayerLeftHandIsClosed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Left Hand Is Closed";
    public string GetVariableQualifiedName() => "playerLeftHandIsClosed";
}