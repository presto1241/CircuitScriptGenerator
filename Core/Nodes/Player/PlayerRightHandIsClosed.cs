/*
 * Filename: PlayerRightHandIsClosed.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs whether or not a Player's right hand is closed.
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

[Node("4de8a478-6edb-4f8f-8406-4b8f16210e1a")]
public class PlayerRightHandIsClosed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Right Hand Is Closed";
    public string GetVariableQualifiedName() => "playerRightHandIsClosed";
}