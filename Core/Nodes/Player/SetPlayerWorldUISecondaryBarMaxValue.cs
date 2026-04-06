/*
 * Filename: SetPlayerWorldUISecondaryBarMaxValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the max value of the secondary bar in the given player's active world UI.
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

[Node("38fa1fe5-e9cf-45b4-8fa7-0633064e4cc3")]
public class SetPlayerWorldUISecondaryBarMaxValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Set Player World UI Secondary Bar Max Value";
    public string GetVariableQualifiedName() => "setPlayerWorldUISecondaryBarMaxValue";
}