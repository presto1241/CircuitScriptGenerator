/*
 * Filename: ButtonGetIsPressed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs a target Button's Pressed property.
 * Types: 
 * 
 * INPUTS: 
 * Target (Button)
 *
 * OUTPUTS: 
 * Is Pressed (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("fe32ba92-9018-4575-92e2-3b0d82c9419b")]
public class ButtonGetIsPressed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Button Get Is Pressed";
    public string GetVariableQualifiedName() => "buttonGetIsPressed";
}