/*
 * Filename: EmitterSetLooping.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Makes the emitter emit continuously or not.
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Emitter)
 * Value (bool)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("36881bd0-7da0-44a7-b6ef-8cd3770fed78")]
public class EmitterSetLooping : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Emitter Set Looping";
    public string GetVariableQualifiedName() => "emitterSetLooping";
}