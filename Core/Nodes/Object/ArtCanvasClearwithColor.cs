/*
 * Filename: ArtCanvasClearwithColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Clears the current image from the Art Canvas by setting it to a single non-transparent color.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Art Canvas)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("2d3e00e1-3d91-4b1d-a014-a95f8ca48c9a")]
public class ArtCanvasClearwithColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Art Canvas Clear with Color";
    public string GetVariableQualifiedName() => "artCanvasClearwithColor";
}