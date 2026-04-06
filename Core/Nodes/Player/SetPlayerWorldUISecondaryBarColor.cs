/*
 * Filename: SetPlayerWorldUISecondaryBarColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the color of the secondary bar in the given player's active world UI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
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

[Node("a94540da-0639-4e88-adf6-c90f6612fe05")]
public class SetPlayerWorldUISecondaryBarColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Player World UI Secondary Bar Color";
    public string GetVariableQualifiedName() => "setPlayerWorldUISecondaryBarColor";
}