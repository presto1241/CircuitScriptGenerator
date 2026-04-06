/*
 * Filename: SnapCameraImage.cs
 * Category: Camera
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Renders the output of a camera to a texture.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Render Texture (Texture)
 * Camera Position (Vector3)
 * Camera Rotation (Quaternion)
 * Field of View (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Camera;

[Node("3d204110-0e60-4a52-a216-17252628d7be")]
public class SnapCameraImage : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Snap Camera Image";
    public string GetVariableQualifiedName() => "snapCameraImage";
}