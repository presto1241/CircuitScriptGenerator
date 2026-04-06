/*
 * Filename: IfPlayerIsLocal.cs
 * Category: Networking
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs if a player is the local player or not.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * Is Local (exec)
 * Is Not Local (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Networking;

[Node("c7643011-f320-4155-89b8-d693730c1935")]
public class IfPlayerIsLocal : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Player Is Local";
    public string GetVariableQualifiedName() => "ifPlayerIsLocal";
}