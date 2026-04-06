/*
 * Filename: UnequipAvatarItem.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Unequips an avatar item on the designated player
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Avatar Item (Avatar Item)
 * Player (Player)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("ff1ca918-3db6-4b4f-b4dd-3317be3141b7")]
public class UnequipAvatarItem : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Unequip Avatar Item";
    public string GetVariableQualifiedName() => "unequipAvatarItem";
}