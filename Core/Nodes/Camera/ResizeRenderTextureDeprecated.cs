/*
 * Filename: ResizeRenderTextureDeprecated.cs
 * Category: Camera
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Resizes an existing Render Texture.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Texture)
 * Width (int)
 * Height (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 * Render Texture (Texture)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Camera;

[Node("b07279be-e580-453f-a684-1c8d4f2565e0")]
public class ResizeRenderTextureDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Resize Render Texture (Deprecated)";
    public string GetVariableQualifiedName() => "resizeRenderTextureDeprecated";
}