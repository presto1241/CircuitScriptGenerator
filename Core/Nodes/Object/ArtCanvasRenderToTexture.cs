/*
 * Filename: ArtCanvasRenderToTexture.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Renders the current content of the canvas into a texture
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target Canvas (Art Canvas)
 * Target Texture (Texture)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("64384c88-96a6-479e-aac6-f6c6209bd4f5")]
public class ArtCanvasRenderToTexture : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Art Canvas Render To Texture";
    public string GetVariableQualifiedName() => "artCanvasRenderToTexture";
}