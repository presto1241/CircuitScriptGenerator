/*
 * Filename: TextureCopyWithResize.cs
 * Category: Texture
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Copies one texture into another texture, resizing the texture content if the dimensions are different
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Source Texture (Texture)
 * Target Texture (Texture)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Texture;

[Node("eb1b1c34-168d-44bc-ad96-79f0283ac99c")]
public class TextureCopyWithResize : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Texture Copy With Resize";
    public string GetVariableQualifiedName() => "textureCopyWithResize";
}