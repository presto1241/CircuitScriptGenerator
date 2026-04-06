/*
 * Filename: ColorToRGB.cs
 * Category: Conversion
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return red, green, and blue from the given color.
 * Types: 
 * 
 * INPUTS: 
 * Color (Color)
 *
 * OUTPUTS: 
 * Red (float)
 * Green (float)
 * Blue (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Conversion;

[Node("52565e5d-73d1-4f29-bca7-0c8ae9afcc57")]
public class ColorToRGB : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Color To RGB";
    public string GetVariableQualifiedName() => "colorToRGB";
}