/*
 * Filename: LocalPlayerSetGravityDisabled.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets whether gravity should be disabled for the local player
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Disabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("6f88b273-5be6-4183-a772-902c45f4a5c7")]
public class LocalPlayerSetGravityDisabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Set Gravity Disabled";
    public string GetVariableQualifiedName() => "localPlayerSetGravityDisabled";
}