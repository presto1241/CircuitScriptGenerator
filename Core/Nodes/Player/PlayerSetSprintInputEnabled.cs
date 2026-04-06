/*
 * Filename: PlayerSetSprintInputEnabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether sprint input is enabled for a given player. Setting this to false will remove sprint button prompts / UI elements on supported platforms.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Sprint Input Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("68b971bc-30af-44d0-ad2f-50a5bbad1f5e")]
public class PlayerSetSprintInputEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Sprint Input Enabled";
    public string GetVariableQualifiedName() => "playerSetSprintInputEnabled";
}