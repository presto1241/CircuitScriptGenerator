/*
 * Filename: IfPlayerIsValid.cs
 * Category: Utilities
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Runs Is Valid if the input player is not null, otherwise runs Is Not Valid. Players can be not valid if a variable is never set or if a player has left the room.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Valid (exec)
 * Is Not Valid (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Utilities;

[Node("ec2ceb32-db91-4f65-8b0a-b66d7f2a7f2d")]
public class IfPlayerIsValid : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Player Is Valid";
    public string GetVariableQualifiedName() => "ifPlayerIsValid";
}