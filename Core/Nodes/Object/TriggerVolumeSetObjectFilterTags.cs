/*
 * Filename: TriggerVolumeSetObjectFilterTags.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the tags that are being used as the object filter for a Trigger Volume. An object is considered by the Trigger Volume, if it has any of the tags in this list.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Trigger Volume)
 * Tags (List<string>)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("6668fd38-076e-4d03-b9a1-02eca5edd0b7")]
public class TriggerVolumeSetObjectFilterTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Set Object Filter Tags";
    public string GetVariableQualifiedName() => "triggerVolumeSetObjectFilterTags";
}