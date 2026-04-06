/*
 * Filename: DownloadTextureFromRecNetDeprecated.cs
 * Category: Image
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Downloads a texture asset from RecNet using a specified RecNet image reference.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * RecNet Image (RecNet Image)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Downloaded (exec)
 * Texture (Texture)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Image;

[Node("05f6ee1f-7589-4a21-b7a5-47d51a563038")]
public class DownloadTextureFromRecNetDeprecated : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Download Texture From RecNet (Deprecated)";
    public string GetVariableQualifiedName() => "downloadTextureFromRecNetDeprecated";
}