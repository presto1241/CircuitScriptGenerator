/*
 * Filename: EmitterSetSpeed.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the speed particles are emitted.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Emitter)
 * Value (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("12446960-d971-475f-b64e-b5c7bb422eca")]
public class EmitterSetSpeed : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Set Speed";
    public string GetVariableQualifiedName() => "emitterSetSpeed";
}