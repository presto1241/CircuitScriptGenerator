/*
 * Filename: PlayerGetWalkSpeed.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the walk speed for a given player
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Walk Speed (m/s) (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("9decb308-a5c1-41d6-8d68-cfc96d894505")]
public class PlayerGetWalkSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Walk Speed";
    public string GetVariableQualifiedName() => "playerGetWalkSpeed";
}