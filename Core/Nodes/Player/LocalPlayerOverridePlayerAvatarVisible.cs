/*
 * Filename: LocalPlayerOverridePlayerAvatarVisible.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Locally override whether my avatar is visible to myself
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Player (Player)
 * Avatar Visible (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("3f975f36-6d75-4e80-aaae-678fec553a4b")]
public class LocalPlayerOverridePlayerAvatarVisible : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Local Player Override Player Avatar Visible";
    public string GetVariableQualifiedName() => "localPlayerOverridePlayerAvatarVisible";
}