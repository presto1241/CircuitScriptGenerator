/*
 * Filename: HolotarProjectorGetCurrentTime.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Get current playback time for Target Holotar Projector
 * Types: 
 * 
 * INPUTS: 
 * Target (Holotar Projector)
 *
 * OUTPUTS: 
 * Time (float)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("9cf6397d-6e8f-4945-95ac-65ec01530d57")]
public class HolotarProjectorGetCurrentTime : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Projector Get Current Time";
    public string GetVariableQualifiedName() => "holotarProjectorGetCurrentTime";
}