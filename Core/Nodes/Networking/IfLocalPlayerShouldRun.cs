/*
 * Filename: IfLocalPlayerShouldRun.cs
 * Category: Networking
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: The "Should Run" port will exec a) if the input player is local or b) if input player is invalid and the local player has authority of the current context.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Acting Player (Player)
 *
 * OUTPUTS: 
 * Should Run (exec)
 * Should Not Run (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Networking;

[Node("6d69bee8-0d77-4d5f-bf35-9794eaaabe81")]
public class IfLocalPlayerShouldRun : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "If Local Player Should Run";
    public string GetVariableQualifiedName() => "ifLocalPlayerShouldRun";
}