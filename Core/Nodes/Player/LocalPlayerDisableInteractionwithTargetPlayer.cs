/*
 * Filename: LocalPlayerDisableInteractionwithTargetPlayer.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Removes the ability for the local player to interact with the provided player. This state is NOT synced with other users, and player interactivity will be removed only for players that ran this chip.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("f99b0a80-f3a6-4e2d-8101-afe3d9e1008d")]
public class LocalPlayerDisableInteractionwithTargetPlayer : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Disable Interaction with Target Player";
    public string GetVariableQualifiedName() => "localPlayerDisableInteractionwithTargetPlayer";
}