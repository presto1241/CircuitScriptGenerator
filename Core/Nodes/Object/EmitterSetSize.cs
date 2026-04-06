/*
 * Filename: EmitterSetSize.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the size of the particles emitted.
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

[Node("1fdf4bab-c868-4ffb-8bfc-b2e360450495")]
public class EmitterSetSize : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Set Size";
    public string GetVariableQualifiedName() => "emitterSetSize";
}