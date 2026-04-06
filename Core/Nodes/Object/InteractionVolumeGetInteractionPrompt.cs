/*
 * Filename: InteractionVolumeGetInteractionPrompt.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Gets the interaction prompt of an Interaction Volume.
 * Types: 
 * 
 * INPUTS: 
 * Target (Interaction Volume)
 *
 * OUTPUTS: 
 * Interaction Prompt (string)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("0c351297-db4d-43e7-81a3-95dc5ddde401")]
public class InteractionVolumeGetInteractionPrompt : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Interaction Volume Get Interaction Prompt";
    public string GetVariableQualifiedName() => "interactionVolumeGetInteractionPrompt";
}