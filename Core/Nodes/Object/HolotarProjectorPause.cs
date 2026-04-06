/*
 * Filename: HolotarProjectorPause.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Pasue Holotar Projector at current playback time
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

[Node("8554d9ff-4ac3-4214-872b-4274fe5a8549")]
public class HolotarProjectorPause : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Projector Pause";
    public string GetVariableQualifiedName() => "holotarProjectorPause";
}