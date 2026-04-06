/*
 * Filename: TextGetColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the color of the target Text gadget.
 * Types: 
 * 
 * INPUTS: 
 * Target (Text)
 *
 * OUTPUTS: 
 * Color (Color)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("2b28277e-29a1-4b97-b151-2f23ff28c4c2")]
public class TextGetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Text Get Color";
    public string GetVariableQualifiedName() => "textGetColor";
}