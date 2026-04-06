/*
 * Filename: PlayerGetEquippedAvatarItemTags.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get Player Equipped Avatar Iterm for provided Outfit Slot Flag
 * Types: 
 * 
 * INPUTS: 
 * Player (Player)
 * Outfit Slot Flag (Player Outfit Slot)
 *
 * OUTPUTS: 
 * Tag List (List<string>) - List of tags associated with the avatar item(s) in the provided slot
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("11eec512-f103-4222-88c5-b26860a19288")]
public class PlayerGetEquippedAvatarItemTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Player Get Equipped Avatar Item Tags";
    public string GetVariableQualifiedName() => "playerGetEquippedAvatarItemTags";
}