/*
 * Filename: ArtCanvasToTextureDeprecated.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Converts the current image on the Art Canvas into a usable texture.
 * Types: 
 * 
 * INPUTS: 
 * Target (Art Canvas)
 *
 * OUTPUTS: 
 * Value (Texture)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9e984943-c182-409c-b8bb-8d88329cbedb")]
public class ArtCanvasToTextureDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Art Canvas To Texture (Deprecated)";
    public string GetVariableQualifiedName() => "artCanvasToTextureDeprecated";
}