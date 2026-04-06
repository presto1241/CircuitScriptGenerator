/*
 * Filename: TextureConstant.cs
 * Category: Constant
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: An Constant node that provides a Texture, which can be used to capture photos, drawings, or other content
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Texture)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Constant;

[Node("872ddeb4-f906-413a-aa1e-a8fb86247e2c")]
public class TextureConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Texture Constant";
    public string GetVariableQualifiedName() => "textureConstant";
}