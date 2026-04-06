/*
 * Filename: PlayerAccountGetDetails.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get information about a player account such as name, bio, profile image, etc.
 * Types: 
 * 
 * INPUTS: 
 * Player Account (Player Account)
 *
 * OUTPUTS: 
 * Display Name (string)
 * Account Name (string)
 * Bio (string)
 * Profile Image (RecNet Image)
 * Subscribers (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("10e69638-623f-4a5e-84ae-a2ed7f6f8ffc")]
public class PlayerAccountGetDetails : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Account Get Details";
    public string GetVariableQualifiedName() => "playerAccountGetDetails";
}