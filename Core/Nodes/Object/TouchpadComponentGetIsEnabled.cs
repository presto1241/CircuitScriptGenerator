/*
 * Filename: TouchpadComponentGetIsEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets if the Touchpad can be interacted with or output touch events
 * Types: 
 * 
 * INPUTS: 
 * Target (Touchpad)
 *
 * OUTPUTS: 
 * IsEnabled (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("64ca9ac0-04a8-4460-afe5-64a927f1ca4a")]
public class TouchpadComponentGetIsEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Touchpad Component Get Is Enabled";
    public string GetVariableQualifiedName() => "touchpadComponentGetIsEnabled";
}