/*
 * Filename: PlayerSetCrouchInputEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether crouch input is enabled for a given player. Setting this to false will remove crouch button prompts / UI elements on supported platforms.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Crouch Input Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("046d23a2-5f34-40dc-a586-008c7bc391f0")]
public class PlayerSetCrouchInputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Crouch Input Enabled";
    public string GetVariableQualifiedName() => "playerSetCrouchInputEnabled";
}