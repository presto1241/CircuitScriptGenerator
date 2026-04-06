/*
 * Filename: ButtonSetText.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets an input Button's Text property.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Button)
 * Text (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("21bbaa09-6bcf-435c-86da-e853a78bc27b")]
public class ButtonSetText : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Button Set Text";
    public string GetVariableQualifiedName() => "buttonSetText";
}