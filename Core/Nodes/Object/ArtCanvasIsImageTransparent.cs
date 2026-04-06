/*
 * Filename: ArtCanvasIsImageTransparent.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Checks if the current Art Canvas image is completely transparent.
 * Types: 
 * 
 * INPUTS: 
 * Target (Art Canvas)
 *
 * OUTPUTS: 
 * Is Image Transparent (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("cfec86ef-1f8a-413c-945f-8b7510c6773a")]
public class ArtCanvasIsImageTransparent : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Art Canvas Is Image Transparent";
    public string GetVariableQualifiedName() => "artCanvasIsImageTransparent";
}