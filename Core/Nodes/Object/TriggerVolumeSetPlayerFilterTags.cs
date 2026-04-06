/*
 * Filename: TriggerVolumeSetPlayerFilterTags.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the tags that are being used as the player filter for a Trigger  Volume. A player is considered by the Trigger Volume, if they have any of the tags in this list.
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

[Node("e53a6e31-af8f-4579-87ba-7e2e49991b04")]
public class TriggerVolumeSetPlayerFilterTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Set Player Filter Tags";
    public string GetVariableQualifiedName() => "triggerVolumeSetPlayerFilterTags";
}