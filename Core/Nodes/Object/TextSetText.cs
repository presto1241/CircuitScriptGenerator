/*
 * Filename: TextSetText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set the visible text for a Text object.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Text)
 * Text (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c941f3a3-d3f6-49cc-a6a4-b7a4e95fd173")]
public class TextSetText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Text Set Text";
    public string GetVariableQualifiedName() => "textSetText";
}