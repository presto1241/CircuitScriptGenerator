/*
 * Filename: EmitterSetColor.cs
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
 * Color (Color)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4263768a-035b-4d8b-b17c-1a7bb0b9b96d")]
public class EmitterSetColor : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Set Color";
    public string GetVariableQualifiedName() => "emitterSetColor";
}