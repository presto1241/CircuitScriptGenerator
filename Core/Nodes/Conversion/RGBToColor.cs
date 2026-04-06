/*
 * Filename: RGBToColor.cs
 * Category: Conversion
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Return a color from the given red, green, and blue inputs. All inputs are in the range [0, 1].
 * Types: 
 * 
 * INPUTS: 
 * Red (float)
 * Green (float)
 * Blue (float)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Conversion;

[Node("c38b908d-df40-4bd0-bf8b-38afe6cbe9e2")]
public class RGBToColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "RGB To Color";
    public string GetVariableQualifiedName() => "rGBToColor";
}