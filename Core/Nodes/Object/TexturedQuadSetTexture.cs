/*
 * Filename: TexturedQuadSetTexture.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Applies a texture to a Textured Quad.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Textured Quad)
 * Value (Texture)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a865ee00-f6ae-4473-a222-3945e66aa09c")]
public class TexturedQuadSetTexture : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Textured Quad Set Texture";
    public string GetVariableQualifiedName() => "texturedQuadSetTexture";
}