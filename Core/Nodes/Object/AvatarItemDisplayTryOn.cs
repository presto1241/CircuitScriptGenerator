/*
 * Filename: AvatarItemDisplayTryOn.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Allows you to try on the avatar item being displayed. Only allowed when Try On is enabled.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Avatar Item Display)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("fa49e6b6-79b7-4c5c-9b9c-1ade11c69e3c")]
public class AvatarItemDisplayTryOn : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Avatar Item Display Try On";
    public string GetVariableQualifiedName() => "avatarItemDisplayTryOn";
}