/*
 * Filename: TriggerVolumeGetFilterRole.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the role name that is being used as a filter for a Trigger Volume.
 * Types: 
 * 
 * INPUTS: 
 * Target (Trigger Volume)
 *
 * OUTPUTS: 
 * Value (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("b49c4e16-93c5-45c3-b457-fb960c661bc5")]
public class TriggerVolumeGetFilterRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Get Filter Role";
    public string GetVariableQualifiedName() => "triggerVolumeGetFilterRole";
}