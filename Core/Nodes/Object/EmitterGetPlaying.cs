/*
 * Filename: EmitterGetPlaying.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if the target Emitter is playing.
 * Types: 
 * 
 * INPUTS: 
 * Target (Emitter)
 *
 * OUTPUTS: 
 * Playing (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9fbee635-c6a4-4a02-a67b-295e075db7c9")]
public class EmitterGetPlaying : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Get Playing";
    public string GetVariableQualifiedName() => "emitterGetPlaying";
}