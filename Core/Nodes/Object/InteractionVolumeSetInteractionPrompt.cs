/*
 * Filename: InteractionVolumeSetInteractionPrompt.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the interaction prompt of an Interaction Volume.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Interaction Volume)
 * Interaction Prompt (string)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("380d8467-bdfa-4724-a62c-1955831f994a")]
public class InteractionVolumeSetInteractionPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Interaction Volume Set Interaction Prompt";
    public string GetVariableQualifiedName() => "interactionVolumeSetInteractionPrompt";
}