/*
 * Filename: PlayerGetSteeringDirection.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Player Get Steering Direction
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Steering Direction (Vector3)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("119718a6-adb8-40b3-9e0c-b48dd5cb9ff3")]
public class PlayerGetSteeringDirection : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Steering Direction";
    public string GetVariableQualifiedName() => "playerGetSteeringDirection";
}