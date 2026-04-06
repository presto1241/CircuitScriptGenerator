/*
 * Filename: PlayerSetSteeringInputEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether walk input is enabled for a given player. Setting this to false will stop Steering Input events from firing, and will remove walk-related button prompts / UI elements on supported platforms.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Steering Input Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("e5f60f37-b6f5-45a8-9ef6-ea38dd908531")]
public class PlayerSetSteeringInputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Steering Input Enabled";
    public string GetVariableQualifiedName() => "playerSetSteeringInputEnabled";
}