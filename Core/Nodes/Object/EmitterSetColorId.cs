/*
 * Filename: EmitterSetColorId.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Sets the color for the particles emitted.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Emitter)
 * Value (int)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("15e42063-cbae-40f9-a9e4-8226e83217ec")]
public class EmitterSetColorId : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Set Color Id";
    public string GetVariableQualifiedName() => "emitterSetColorId";
}