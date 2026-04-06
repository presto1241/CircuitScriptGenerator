/*
 * Filename: TriggerVolumeGetObjectCount.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the number of objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
 * Types: 
 * 
 * INPUTS: 
 * Target (Trigger Volume)
 *
 * OUTPUTS: 
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("338c7e0a-fa55-49e1-91e8-1609d00f1fd0")]
public class TriggerVolumeGetObjectCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Get Object Count";
    public string GetVariableQualifiedName() => "triggerVolumeGetObjectCount";
}