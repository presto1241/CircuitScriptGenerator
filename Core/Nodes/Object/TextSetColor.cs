/*
 * Filename: TextSetColor.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the color for a Text object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Text)
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0bfaa337-46a1-472f-beac-12faa21867d4")]
public class TextSetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Text Set Color";
    public string GetVariableQualifiedName() => "textSetColor";
}