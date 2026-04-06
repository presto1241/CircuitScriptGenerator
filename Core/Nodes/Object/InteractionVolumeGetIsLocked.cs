/*
 * Filename: InteractionVolumeGetIsLocked.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns False if the Interaction Volume is enabled, and True if it is locked.
 * Types: 
 * 
 * INPUTS: 
 * Target (Interaction Volume)
 *
 * OUTPUTS: 
 * Is Locked (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("c536089c-e2c3-4a6a-a4fa-aba8dca6b810")]
public class InteractionVolumeGetIsLocked : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Interaction Volume Get Is Locked";
    public string GetVariableQualifiedName() => "interactionVolumeGetIsLocked";
}