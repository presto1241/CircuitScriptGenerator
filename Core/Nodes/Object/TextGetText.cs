/*
 * Filename: TextGetText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the visible text for a Text object.
 * Types: 
 * 
 * INPUTS: 
 * Target (Text)
 *
 * OUTPUTS: 
 * Text (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("3e8fbb88-3179-4a4c-9f8f-d9c2db35b9b5")]
public class TextGetText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Text Get Text";
    public string GetVariableQualifiedName() => "textGetText";
}