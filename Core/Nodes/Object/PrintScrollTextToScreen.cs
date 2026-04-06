/*
 * Filename: PrintScrollTextToScreen.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Print to screen and scroll it
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Text Screen Scroll)
 * Text (string)
 * Color (Color)
 * Speed (float)
 * ScrollTime (float)
 * Size (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("adedbf01-fed4-46f7-9a11-48f0ccdd0e4c")]
public class PrintScrollTextToScreen : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Print Scroll Text To Screen";
    public string GetVariableQualifiedName() => "printScrollTextToScreen";
}