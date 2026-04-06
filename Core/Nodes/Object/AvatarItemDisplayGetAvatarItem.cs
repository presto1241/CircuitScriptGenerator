/*
 * Filename: AvatarItemDisplayGetAvatarItem.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the avatar item that is being shown on the inputted Avatar Item Display
 * Types: 
 * 
 * INPUTS: 
 * Target (Avatar Item Display)
 *
 * OUTPUTS: 
 * Avatar Item (Avatar Item)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("488255c5-3629-4c28-902e-6e1b9c93d1d2")]
public class AvatarItemDisplayGetAvatarItem : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Avatar Item Display Get Avatar Item";
    public string GetVariableQualifiedName() => "avatarItemDisplayGetAvatarItem";
}