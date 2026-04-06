/*
 * Filename: LocalPlayerGetIsThirdPersonActive.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Checks if the local player is in third-person mode. This always returns false for platforms that do not support third person like VR.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Active (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("d6d17e6f-855e-4f5a-9e33-843a788ce3a0")]
public class LocalPlayerGetIsThirdPersonActive : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Get Is Third Person Active";
    public string GetVariableQualifiedName() => "localPlayerGetIsThirdPersonActive";
}