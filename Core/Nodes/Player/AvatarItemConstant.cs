/*
 * Filename: AvatarItemConstant.cs
 * Category: Player
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Can be configured to select an avatar item, and then provides that value to circuits
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Avatar Item)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Player;

[Node("8f50095d-2d76-4770-b862-1e415c12f559")]
public class AvatarItemConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Avatar Item Constant";
    public string GetVariableQualifiedName() => "avatarItemConstant";
}