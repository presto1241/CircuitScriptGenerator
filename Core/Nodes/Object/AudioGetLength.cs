/*
 * Filename: AudioGetLength.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the length in seconds of the given audio reference.
 * Types: 
 * 
 * INPUTS: 
 * Audio (Audio)
 *
 * OUTPUTS: 
 * Length (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("be5262f0-1f67-4be7-aa8c-967c30bd5487")]
public class AudioGetLength : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Audio Get Length";
    public string GetVariableQualifiedName() => "audioGetLength";
}