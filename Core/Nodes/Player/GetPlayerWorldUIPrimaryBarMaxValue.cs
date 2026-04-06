/*
 * Filename: GetPlayerWorldUIPrimaryBarMaxValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the max value of the given player's primary bar in their current world UI.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Max Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("30eb2838-1409-4266-96ed-31b3e1e25408")]
public class GetPlayerWorldUIPrimaryBarMaxValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Primary Bar Max Value";
    public string GetVariableQualifiedName() => "getPlayerWorldUIPrimaryBarMaxValue";
}