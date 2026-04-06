/*
 * Filename: HolotarProjectorSetCurrentTime.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Set playback time for Target Projector when paused or playing
 * Types: 
 * 
 * INPUTS: 
 * (unnamed) (exec)
 * Target (Holotar Projector)
 * Time (float)
 *
 * OUTPUTS: 
 * (unnamed) (exec)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("4529edc7-0fb7-48b0-a685-8600ac73b7df")]
public class HolotarProjectorSetCurrentTime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Projector Set Current Time";
    public string GetVariableQualifiedName() => "holotarProjectorSetCurrentTime";
}