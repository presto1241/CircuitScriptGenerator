/*
 * Filename: PlayerSetCanFly.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether the given player is allowed to fly. This is enforced via circuits in the default player definition board and may not do anything if that logic has been changed.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Can Fly (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("c860b9ba-b6ae-43fa-b013-b163a7fb49fe")]
public class PlayerSetCanFly : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Can Fly";
    public string GetVariableQualifiedName() => "playerSetCanFly";
}