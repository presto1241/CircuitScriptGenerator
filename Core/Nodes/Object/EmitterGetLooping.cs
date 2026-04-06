/*
 * Filename: EmitterGetLooping.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns True if the target Emitter is looping.
 * Types: 
 * 
 * INPUTS: 
 * Target (Emitter)
 *
 * OUTPUTS: 
 * Looping (bool)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("f8c91da0-bb4f-4958-9016-546a387f45dd")]
public class EmitterGetLooping : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Get Looping";
    public string GetVariableQualifiedName() => "emitterGetLooping";
}