/*
 * Filename: LocalPlayerClearPlayerAvatarVisibleOverride.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the local override value for Avatar Visible player property
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("10e41b18-a756-42c7-a7a7-0dd2d7a90e75")]
public class LocalPlayerClearPlayerAvatarVisibleOverride : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Clear Player Avatar Visible Override";
    public string GetVariableQualifiedName() => "localPlayerClearPlayerAvatarVisibleOverride";
}