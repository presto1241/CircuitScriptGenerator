/*
 * Filename: PlayerAddRole.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Adds a Role to a Player.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Player)
 * Value (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("7b725036-4996-441d-ac54-91ac2c23d6b3")]
public class PlayerAddRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Add Role";
    public string GetVariableQualifiedName() => "playerAddRole";
}