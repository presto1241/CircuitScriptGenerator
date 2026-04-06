/*
 * Filename: ButtonGetText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs a target Button's Text property.
 * Types: 
 * 
 * INPUTS: 
 * Target (Button)
 *
 * OUTPUTS: 
 * Text (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("70e7663d-a5fd-435d-8995-942b4babc262")]
public class ButtonGetText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Button Get Text";
    public string GetVariableQualifiedName() => "buttonGetText";
}