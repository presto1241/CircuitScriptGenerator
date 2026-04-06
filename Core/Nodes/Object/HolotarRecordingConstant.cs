/*
 * Filename: HolotarRecordingConstant.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Constant to record and save a Holotar clip
 * Types: 
 * 
 * INPUTS: 
 * 
 *
 * OUTPUTS: 
 * (unnamed) (Holotar Recording)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("a01d55f9-3a69-4edf-bdfa-20beff06148a")]
public class HolotarRecordingConstant : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "Holotar Recording Constant";
    public string GetVariableQualifiedName() => "holotarRecordingConstant";
}