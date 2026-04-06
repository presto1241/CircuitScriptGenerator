/*
 * Filename: HolotarProjectorPlay.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Load & play Holotar Recording from the start through the Target Projector. Play will always begin the clip from 0s
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Holotar Projector)
 * Holotar (Holotar Recording)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("17fa140e-4112-4362-8d04-16aa2ae95d44")]
public class HolotarProjectorPlay : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Projector Play";
    public string GetVariableQualifiedName() => "holotarProjectorPlay";
}