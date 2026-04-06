/*
 * Filename: SFXGetVolume.cs
 * Category: Object
 * Created Date: 2026-04-06T00:22:41+00:00
 * Author: Preston
 * 
 * Description: Outputs the volume of an SFX object.
 * Types: 
 * 
 * INPUTS: 
 * Target (SFX)
 *
 * OUTPUTS: 
 * Value (int)
 *
 */
using CircuitScriptGenerator.Core.Api.Nodes;
using CircuitScriptGenerator.Core.Data;

namespace CircuitScriptGenerator.Core.Nodes.Object;

[Node("aaf39143-c5dc-47cd-ad85-c659c3035cab")]
public class SFXGetVolume : INodeBehaviour
{
    public void Generate(List<Port> inputPorts, List<Port> outputPorts)
    {
        throw new NotImplementedException();
    }

    public string GetName() => "SFX Get Volume";
    public string GetVariableQualifiedName() => "sFXGetVolume";
}