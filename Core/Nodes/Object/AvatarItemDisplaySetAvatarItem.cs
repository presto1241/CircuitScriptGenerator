/*
 * Filename: AvatarItemDisplaySetAvatarItem.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the avatar item to be displayed.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Avatar Item Display)
 * Avatar Item (Avatar Item)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("90b11dcd-a703-4c54-b96f-9fd692e63ba4")]
public class AvatarItemDisplaySetAvatarItem : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Avatar Item Display Set Avatar Item";
    public string GetVariableQualifiedName() => "avatarItemDisplaySetAvatarItem";
}