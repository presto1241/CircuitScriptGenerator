/*
 * Filename: TriggerVolumeGetPlayerFilterTags.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the tags that are being used as the player filter for a Trigger Volume.
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

[Node("7c71350c-67fe-4e57-953b-0b4230a77878")]
public class TriggerVolumeGetPlayerFilterTags : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Get Player Filter Tags";
    public string GetVariableQualifiedName() => "triggerVolumeGetPlayerFilterTags";
}