/*
 * Filename: PlayerSetJumpInputEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether jump input is enabled for a given player. Setting this to false will remove jump button prompts / UI elements on supported platforms.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Jump Input Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d837f992-bcc3-4571-b402-c39a5378e1ee")]
public class PlayerSetJumpInputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Jump Input Enabled";
    public string GetVariableQualifiedName() => "playerSetJumpInputEnabled";
}