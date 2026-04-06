/*
 * Filename: PlayerGetCanFly.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns whether the given player is allowed to fly. This is enforced via circuits in the default player definition board and may not do anything if that logic has been changed.
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 *
 * OUTPUTS: 
 * Can Fly (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("b9e436c5-970f-46c4-80a9-d2950a130f01")]
public class PlayerGetCanFly : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Can Fly";
    public string GetVariableQualifiedName() => "playerGetCanFly";
}