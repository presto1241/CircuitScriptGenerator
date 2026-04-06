/*
 * Filename: IfPlayerHasRole.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Runs Has Role if the input player has the input role, otherwise runs Does Not Have Role.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Role (string)
 *
 * OUTPUTS: 
 * Has Role (exec)
 * Does Not Have Role (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("502d09f5-85ce-45fc-b6a1-3a3eecce8562")]
public class IfPlayerHasRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Player Has Role";
    public string GetVariableQualifiedName() => "ifPlayerHasRole";
}