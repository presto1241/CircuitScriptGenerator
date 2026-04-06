/*
 * Filename: GetPlayerWorldUISecondaryBarMaxValue.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the max value of the given player's secondary bar in their current world UI.
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

[Node("b23bdd96-7676-4236-a5ab-ca0aae513916")]
public class GetPlayerWorldUISecondaryBarMaxValue : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Get Player World UI Secondary Bar Max Value";
    public string GetVariableQualifiedName() => "getPlayerWorldUISecondaryBarMaxValue";
}