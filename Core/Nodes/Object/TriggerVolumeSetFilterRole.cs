/*
 * Filename: TriggerVolumeSetFilterRole.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the role name that is being used as a filter for a Trigger Volume.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Trigger Volume)
 * Value (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("55cfecf9-2623-4aad-948c-6ca89f11911b")]
public class TriggerVolumeSetFilterRole : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Set Filter Role";
    public string GetVariableQualifiedName() => "triggerVolumeSetFilterRole";
}