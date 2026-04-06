/*
 * Filename: TriggerVolumeGetObjects.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets all of the objects currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
 * Types: 
 * 
 * INPUTS: 
 * Target (Trigger Volume)
 *
 * OUTPUTS: 
 * Value (List<Rec Room Object>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("530932a7-8781-4b09-a945-b33af6675809")]
public class TriggerVolumeGetObjects : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Get Objects";
    public string GetVariableQualifiedName() => "triggerVolumeGetObjects";
}