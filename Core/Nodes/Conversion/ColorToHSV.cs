/*
 * Filename: ColorToHSV.cs
 * Category: Conversion
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return hue, saturation, and value from the given color.
 * Types: 
 * 
 * INPUTS: 
 * Color (Color)
 *
 * OUTPUTS: 
 * Hue (float)
 * Saturation (float)
 * Value (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Conversion;

[Node("d697171e-56ac-41b7-aa1e-dabc4538c029")]
public class ColorToHSV : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Color To HSV";
    public string GetVariableQualifiedName() => "colorToHSV";
}