/*
 * Filename: EmitterGetSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the speed multiplier of the target Emitter.
 * Types: 
 * 
 * INPUTS: 
 * Target (Emitter)
 *
 * OUTPUTS: 
 * Speed (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("df10f3b8-e5b8-49ad-9112-22cc0e3bdb9f")]
public class EmitterGetSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Get Speed";
    public string GetVariableQualifiedName() => "emitterGetSpeed";
}