/*
 * Filename: PlayerSetForceVRWalk.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Forces the given player to use walk rather than teleport mode if they are playing in VR. This is useful when you need access to their walk inputs which won't fire if they are in teleport mode. You should consider adding a warning to your room so teleport players are aware that you're going to change their movement mode.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Force VR Walk (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("c4fa9164-e585-4813-93f4-b31da5635a8b")]
public class PlayerSetForceVRWalk : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Force VR Walk";
    public string GetVariableQualifiedName() => "playerSetForceVRWalk";
}