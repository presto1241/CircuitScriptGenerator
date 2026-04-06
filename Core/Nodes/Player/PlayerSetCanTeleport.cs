/*
 * Filename: PlayerSetCanTeleport.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether a given player is allowed to teleport.

Note: Setting this to false does not prevent VR players from being in Teleport mode. It only prevents them from performing a teleport.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Can Teleport (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("de2df219-9d85-4778-a9a3-255d912596a2")]
public class PlayerSetCanTeleport : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Can Teleport";
    public string GetVariableQualifiedName() => "playerSetCanTeleport";
}