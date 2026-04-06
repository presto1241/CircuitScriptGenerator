/*
 * Filename: SetPlayerWorldUIPrimaryBarMaxValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the max value of the primary bar in the given player's active world UI.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Value (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("eafda897-0a2a-41a7-bce4-7f7b62c7e887")]
public class SetPlayerWorldUIPrimaryBarMaxValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Player World UI Primary Bar Max Value";
    public string GetVariableQualifiedName() => "setPlayerWorldUIPrimaryBarMaxValue";
}