/*
 * Filename: HSVToColor.cs
 * Category: Conversion
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return a color from the given hue, saturation, and value inputs. All inputs are in the range [0, 1].
 * Types: 
 * 
 * INPUTS: 
 * Hue (float)
 * Saturation (float)
 * Value (float)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Conversion;

[Node("2e8d2d58-a73d-407a-9892-6cac4cb9ce9a")]
public class HSVToColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "HSV To Color";
    public string GetVariableQualifiedName() => "hSVToColor";
}