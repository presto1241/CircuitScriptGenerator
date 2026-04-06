/*
 * Filename: HolotarProjectorSetVolume.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Holotar Projector set playback volume
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Holotar Projector)
 * Volume (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4cc01ea7-d5ce-4877-883a-9492e6e48c9e")]
public class HolotarProjectorSetVolume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Projector Set Volume";
    public string GetVariableQualifiedName() => "holotarProjectorSetVolume";
}