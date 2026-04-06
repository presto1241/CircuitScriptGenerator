/*
 * Filename: HolotarProjectorStop.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Holotar Projector end play
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Holotar Projector)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("943fdeaa-a9d8-4ddf-aa21-04bc3f022f58")]
public class HolotarProjectorStop : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Projector Stop";
    public string GetVariableQualifiedName() => "holotarProjectorStop";
}