/*
 * Filename: TriggerVolumeGetPlayerCount.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the number of players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
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

[Node("4cbe661b-7053-4c19-9ccf-1600c7a41016")]
public class TriggerVolumeGetPlayerCount : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Get Player Count";
    public string GetVariableQualifiedName() => "triggerVolumeGetPlayerCount";
}