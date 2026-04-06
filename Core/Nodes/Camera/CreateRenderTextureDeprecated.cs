/*
 * Filename: CreateRenderTextureDeprecated.cs
 * Category: Camera
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Creates a Render Texture compatible with the Snap Camera Image chip.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
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

[Node("ab09e7cc-a31c-4fb0-8df7-8f37ace6514e")]
public class CreateRenderTextureDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Create Render Texture (Deprecated)";
    public string GetVariableQualifiedName() => "createRenderTextureDeprecated";
}