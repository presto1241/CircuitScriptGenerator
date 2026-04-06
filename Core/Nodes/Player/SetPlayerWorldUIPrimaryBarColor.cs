/*
 * Filename: SetPlayerWorldUIPrimaryBarColor.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the color of the primary bar in the given player's active world UI.
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

[Node("859086b7-8a86-4dde-b8cb-c3a361d13fe3")]
public class SetPlayerWorldUIPrimaryBarColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Player World UI Primary Bar Color";
    public string GetVariableQualifiedName() => "setPlayerWorldUIPrimaryBarColor";
}