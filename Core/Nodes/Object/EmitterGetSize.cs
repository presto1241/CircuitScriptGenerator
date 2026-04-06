/*
 * Filename: EmitterGetSize.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Returns the size multiplier of the target Emitter.
 * Types: 
 * 
 * INPUTS: 
 * Target (Emitter)
 *
 * OUTPUTS: 
 * Size (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("08c3c01c-2c40-4b92-a913-e5a8cbbbe352")]
public class EmitterGetSize : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Get Size";
    public string GetVariableQualifiedName() => "emitterGetSize";
}