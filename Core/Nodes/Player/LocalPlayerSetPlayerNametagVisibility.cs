/*
 * Filename: LocalPlayerSetPlayerNametagVisibility.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Control whether the player sees the nametag of the target player.It takes priority over role settings.Reset the room to remove the effect of this chip.
 * Types: 
 * 
 * INPUTS: 
 * Set Visibility (exec)
 * Player (Player)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * Set Visibility (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("a73655df-b37b-4c02-a19a-4eb05ce75a14")]
public class LocalPlayerSetPlayerNametagVisibility : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Player Nametag Visibility";
    public string GetVariableQualifiedName() => "localPlayerSetPlayerNametagVisibility";
}