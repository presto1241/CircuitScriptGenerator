/*
 * Filename: InteractionVolumeGetHoldTime.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the required hold time for the target Interaction Volume.
 * Types: 
 * 
 * INPUTS: 
 * Target (Interaction Volume)
 *
 * OUTPUTS: 
 * Hold Time (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("90e2d8e3-6cdc-4b52-b7e9-529c98e5ee09")]
public class InteractionVolumeGetHoldTime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Interaction Volume Get Hold Time";
    public string GetVariableQualifiedName() => "interactionVolumeGetHoldTime";
}