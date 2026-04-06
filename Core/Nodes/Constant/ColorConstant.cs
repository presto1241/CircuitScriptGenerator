/*
 * Filename: ColorConstant.cs
 * Category: Constant
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: A constant that can be configured to a custom color, and provide that value to circuits
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Constant;

[Node("87a8e178-b15c-4c38-9da0-95ba74f9f4ec")]
public class ColorConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Color Constant";
    public string GetVariableQualifiedName() => "colorConstant";
}