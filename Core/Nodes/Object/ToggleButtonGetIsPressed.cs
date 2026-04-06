/*
 * Filename: ToggleButtonGetIsPressed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs True if the toggle button is pressed.
 * Types: 
 * 
 * INPUTS: 
 * Target (Toggle Button)
 *
 * OUTPUTS: 
 * Is Pressed (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f8a9cb84-dcb1-4a12-ae29-4d7711e14506")]
public class ToggleButtonGetIsPressed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Toggle Button Get Is Pressed";
    public string GetVariableQualifiedName() => "toggleButtonGetIsPressed";
}