/*
 * Filename: StudioAudioConstant.cs
 * Category: Rec Room Studio
 * Created Date: 2026-04-05T23:55:26+00:00
 * Author: Preston
 * 
 * Description: An Audio Constant node that provides a list of Audio Clips originally defined in Rec Room Studio. Inventions may contribute to this list.
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Audio)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Rec Room Studio;

[Node("7dc47ad4-9b51-4cb3-8e40-6b76f1243e6f")]
public class StudioAudioConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Studio Audio Constant";
    public string GetVariableQualifiedName() => "studioAudioConstant";
}