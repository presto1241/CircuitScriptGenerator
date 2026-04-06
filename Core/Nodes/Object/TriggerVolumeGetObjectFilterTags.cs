/*
 * Filename: TriggerVolumeGetObjectFilterTags.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the tags that are being used as the object filter for a Trigger Volume.
 * Types: 
 * 
 * INPUTS: 
 * Target (Trigger Volume)
 *
 * OUTPUTS: 
 * Tags (List<string>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("8f42f9b7-87fb-4f4b-9160-a45baf269650")]
public class TriggerVolumeGetObjectFilterTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Get Object Filter Tags";
    public string GetVariableQualifiedName() => "triggerVolumeGetObjectFilterTags";
}