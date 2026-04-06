/*
 * Filename: HolotarProjectorGetVolume.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Holotar Projector get playback volume
 * Types: 
 * 
 * INPUTS: 
 * Target (Holotar Projector)
 *
 * OUTPUTS: 
 * Volume (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("973bc740-7e2b-48ac-911d-7eadfdc1833e")]
public class HolotarProjectorGetVolume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Projector Get Volume";
    public string GetVariableQualifiedName() => "holotarProjectorGetVolume";
}