/*
 * Filename: IfPlayerIsValidAndLocal.cs
 * Category: Networking
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: If the input player is invalid, this runs Is Not Valid. If the input player is valid but not the local player, this runs Is Valid And Not Local. If the input player is both valid and the local player, this runs Is Valid And Local. Players can be invalid if a variable is never set or if a player has left the room.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Valid And Local (exec)
 * Is Not Valid (exec)
 * Is Valid And Not Local (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Networking;

[Node("c1049bfc-902d-4a1a-8b28-1a80b6f26588")]
public class IfPlayerIsValidAndLocal : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Player Is Valid And Local";
    public string GetVariableQualifiedName() => "ifPlayerIsValidAndLocal";
}