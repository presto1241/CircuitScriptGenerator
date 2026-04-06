/*
 * Filename: PlayerSetForceVirtualHeightMode.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether Virtual Height Mode is required for a given player.

Players can choose whether they want to use Physical Height Mode in their settings.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Force Virtual Height Mode (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("2d73b51d-5703-4a1a-bb80-acc05161e3dc")]
public class PlayerSetForceVirtualHeightMode : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Force Virtual Height Mode";
    public string GetVariableQualifiedName() => "playerSetForceVirtualHeightMode";
}