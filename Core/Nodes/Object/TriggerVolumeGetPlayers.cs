/*
 * Filename: TriggerVolumeGetPlayers.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets all of the players currently inside a Trigger Volume. This is not synchronized with the Trigger Volume's events!
 * Types: 
 * 
 * INPUTS: 
 * Target (Trigger Volume)
 *
 * OUTPUTS: 
 * Value (List<Player>)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4c23af85-e05c-4be7-a708-c2f0cc67ebec")]
public class TriggerVolumeGetPlayers : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Trigger Volume Get Players";
    public string GetVariableQualifiedName() => "triggerVolumeGetPlayers";
}