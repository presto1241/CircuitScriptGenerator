/*
 * Filename: PlayerHasRole.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the input player has the input role.
 * Types: 
 * 
 * INPUTS: 
 * Target (Player)
 * Value (string)
 *
 * OUTPUTS: 
 * Value (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("9b39ed47-e9a5-4f04-b4cd-80f5bbaff2f7")]
public class PlayerHasRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Has Role";
    public string GetVariableQualifiedName() => "playerHasRole";
}