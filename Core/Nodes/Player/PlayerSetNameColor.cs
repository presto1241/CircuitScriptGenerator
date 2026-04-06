/*
 * Filename: PlayerSetNameColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the color of the target player's overhead nametag
 * Types: 
 * 
 * INPUTS: 
 * Set (exec)
 * Player (Player)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("19d7fe7e-99e9-444c-8e4f-12c5237abe90")]
public class PlayerSetNameColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Set Name Color";
    public string GetVariableQualifiedName() => "playerSetNameColor";
}