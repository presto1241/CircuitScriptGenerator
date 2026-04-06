/*
 * Filename: PlayerGetForceVRWalk.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the given player will be forced to use walk mode if they are playing in VR. 
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Force VR Walk (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("5711c16e-3550-4d35-a549-cfa704b9d556")]
public class PlayerGetForceVRWalk : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Force VR Walk";
    public string GetVariableQualifiedName() => "playerGetForceVRWalk";
}