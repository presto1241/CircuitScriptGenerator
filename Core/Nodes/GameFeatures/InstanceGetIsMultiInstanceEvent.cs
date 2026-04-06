/*
 * Filename: InstanceGetIsMultiInstanceEvent.cs
 * Category: Game Features
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns true when the current room instance is part of a multi-instance event.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * Is Multi-Instance Event (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.GameFeatures;

[Node("bcaa0819-f788-49ed-91d5-767484c48dea")]
public class InstanceGetIsMultiInstanceEvent : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Instance Get Is Multi-Instance Event";
    public string GetVariableQualifiedName() => "instanceGetIsMultiInstanceEvent";
}