/*
 * Filename: GetPlayerWorldUIPrimaryBarValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the value of the given player's primary bar in their current world UI.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 *
 * OUTPUTS: 
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("84f241f5-fa59-43a3-9b2d-029b831e9275")]
public class GetPlayerWorldUIPrimaryBarValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Primary Bar Value";
    public string GetVariableQualifiedName() => "getPlayerWorldUIPrimaryBarValue";
}