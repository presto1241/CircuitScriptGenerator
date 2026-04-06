/*
 * Filename: TouchpadComponentSetIsEnabled.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets if the Touchpad can be interacted with or output touch events
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Touchpad)
 * Enabled (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("1f27359f-71ca-4827-ab17-5acbdb027837")]
public class TouchpadComponentSetIsEnabled : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Touchpad Component Set Is Enabled";
    public string GetVariableQualifiedName() => "touchpadComponentSetIsEnabled";
}