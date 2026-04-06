/*
 * Filename: DownloadRecNetImageToTexture.cs
 * Category: Image
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Downloads a RecNet image into the specified texture
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * RecNet Image (RecNet Image)
 * Target Texture (Texture)
 *
 * OUTPUTS: 
 * Immediate (exec)
 * On Downloaded (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Image;

[Node("43a58611-6752-4038-9721-2924378e4f65")]
public class DownloadRecNetImageToTexture : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Download RecNet Image To Texture";
    public string GetVariableQualifiedName() => "downloadRecNetImageToTexture";
}