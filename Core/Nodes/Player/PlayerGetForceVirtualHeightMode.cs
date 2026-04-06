/*
 * Filename: PlayerGetForceVirtualHeightMode.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether Virtual Height Mode is required for a given player. 
This is a VR feature that allows players to use button inputs to control their height instead of relying on head position.
Required for VR crouch inputs.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Force Virtual Height Mode (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("1f8923fe-d4dd-45c8-8161-b69bb4a1704e")]
public class PlayerGetForceVirtualHeightMode : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Force Virtual Height Mode";
    public string GetVariableQualifiedName() => "playerGetForceVirtualHeightMode";
}