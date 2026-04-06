/*
 * Filename: PrintTextToScreen.cs
 * Category: Misc
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Prints the specified text to the target Text Screen in the specified color
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Text Screen)
 * Text (string)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Misc;

[Node("5f9f8c85-8aaa-4c9d-9d9d-4c952053b623")]
public class PrintTextToScreen : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Print Text To Screen";
    public string GetVariableQualifiedName() => "printTextToScreen";
}