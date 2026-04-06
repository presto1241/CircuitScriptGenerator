/*
 * Filename: LocalPlayerGetIsRespawning.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Checks if the player is in the middle of respawning
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Respawning (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("43c23f14-b2fa-4ea7-94fc-4abd19486711")]
public class LocalPlayerGetIsRespawning : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Get Is Respawning";
    public string GetVariableQualifiedName() => "localPlayerGetIsRespawning";
}